using R10;

namespace Tasks;
public static class Tasks
{
    # region Приклад, як повинні виглядати виконані завдання:
    public static string TaskExample(IEnumerable<string> stringList)
    {
        return stringList.Aggregate<string>((x, y) => x + y);
    }
    #endregion




    #region Легкий рівень
    public static IEnumerable<Device> Task1_DevicesWithPriceLessThen(IEnumerable<Device> devices, decimal maxPrice)
    {
        return devices.Where(num => num.Price < maxPrice);
    }

    public static IEnumerable<MobilePhone> Task2_MobilePhonesSelect(IEnumerable<Device> devices)
    {
        return devices.OfType<MobilePhone>();

    }

    public static int Task3_ManufacturersDevicesCount(IEnumerable<Device> devices, int manufacturerId)
    {
        return devices.Count(dev => dev.ManufacturerId == manufacturerId);
    }


    public static IEnumerable<Device> Task4_MegapixelsHigherThen(IEnumerable<Device> devices, int megapixels)
    {
        return devices.Where(dev => dev.Camera is Camera && ((Camera)dev.Camera).Megapixels > megapixels);
    }

    public static IEnumerable<Device> Task5_ScreenSizeFromRange(IEnumerable<Device> devices, double minSize, double maxSize)
    {
        return devices.Where(dev => dev.ScreenSize >= minSize && dev.ScreenSize <= maxSize);
    }
    #endregion





    #region Середній рівень
    public static int Task6_LongNameLength(IEnumerable<string> names)
    {
        var a = names.FirstOrDefault(name => name.Length >= 5);
        return a.Length;
    }

    public static IEnumerable<int> Task7_FilterSkipReverse(IEnumerable<int> numbers1, IEnumerable<int> numbers2)
    {
        return numbers1.Except(numbers2).Skip(3).Reverse();
    }

    public static int Task8_ManufacturersCount(IEnumerable<Device> devices)
    {
        return devices.Select(device => device.ManufacturerId).Distinct().Count();
    }

    public static IEnumerable<int> Task9_TakeWhileBelow10(IEnumerable<int> numbers1, IEnumerable<int> numbers2)
    {
        return numbers1.TakeWhile(numb => numb <= 10).Union(numbers2).OrderByDescending(number => number);
    }

    public static IEnumerable<string> Task10_CamerasBetterThanPhones(IEnumerable<Device> devices)
    {
        return
            devices
            .OfType<MobilePhone>()
            .Where(phone => phone.Category != null && phone.Camera.Megapixels > devices.OfType<Camera>().Max(dev => dev.Megapixels))
            .Select(phone => phone.Name)
            .OrderBy(name => name);
    }

    #endregion



    #region Складний рівень
    public static IEnumerable<Device> Task11_CheapestDevicesForEachManufacturer(IEnumerable<Device> devices)
    {


        return devices.GroupBy(d => d.ManufacturerId)
                      .Select(g => g.OrderBy(d => d.Price).ThenByDescending(d => d.UserRating).First())
                      .OrderBy(d => d.Price);
    }


    public static IEnumerable<(string ManufacturerName, string DeviceName)> Task12_DevicesAndManufacturers(IEnumerable<Device> devices, IEnumerable<Manufacturer> manufacturers)
    {
        return devices.Join(manufacturers, d => d.ManufacturerId, m => m.Id, (d, m) => (ManufacturerName: m.Name, DeviceName: d.Name)).OrderBy(tuple => tuple.ManufacturerName).ThenBy(tuple => tuple.DeviceName);


    }

    public static string Task13_DeviceRatingReport(IEnumerable<Device> devices)
    {
        var ratingGroups = devices.GroupBy(d => d.UserRating, (rating, devices) => $"✲{rating} - {devices.Count()}");
        return string.Join(", ", ratingGroups.OrderByDescending(group => group));

    }

    public static IEnumerable<ProductionReport> Task14_ManufacturerProductionReport(IEnumerable<Device> devices, IEnumerable<Manufacturer> manufacturers)
    {
        return manufacturers.Select(m => new ProductionReport
        {
            ManufacturerName = m.Name,
            Devices = devices.Where(d => d.ManufacturerId == m.Id)
        });
    }

    public static IEnumerable<CategoryStats> Task15_GetStatsForCategories(IEnumerable<Device> devices, IEnumerable<Manufacturer> manufacturers)
    {
        var categoryStats = devices.GroupBy(d => d.Category)
                                  .Select(group => new CategoryStats
                                  {
                                      Category = group.Key,
                                      DeviceCount = group.Count(),
                                      ManufacturersCount = group.Select(d => d.ManufacturerId).Distinct().Count()
                                  });
        return categoryStats.OrderByDescending(stats => stats.DeviceCount)
                           .ThenByDescending(stats => stats.ManufacturersCount)
                           .ThenBy(stats => stats.Category);

    }
    #endregion
}