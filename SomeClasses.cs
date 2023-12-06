namespace R10;
public class Device
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int ManufacturerId { get; set; }
    public decimal Price { get; set; }
    public double ScreenSize { get; set; }
    public Camera Camera { get; set; }
    public string Category { get; set; }
    public int UserRating { get; set; }
    public Device() { }
    public Device(string id, string name, int manufacturerId, decimal price, double screenSize, Camera camera, int userRating, string category)
    {
        Id = id;
        Name = name;
        ManufacturerId = manufacturerId;
        Price = price;
        ScreenSize = screenSize;
        Camera = camera;
        Category = category;
        UserRating = userRating;
    }

    public Device(int ManufacturerId, int UserRating)
    {
        this.Id = "";
        this.ManufacturerId = ManufacturerId;
        this.UserRating = UserRating;
    }

}

public class MobilePhone : Device
{
    public string SIMCardType { get; set; }
    public MobilePhone(string id, string name, int manufacturerId, decimal price, double screenSize, Camera camera, int userRating, string simCardType)
        : base(id, name, manufacturerId, price, screenSize, camera, userRating, null)
    {
        base.Id = "M" + id;
        Category = "Phones";
        SIMCardType = simCardType;
    }
}

public class Camera : Device
{
    public int Megapixels { get; set; }
    public Camera(int megapixels) 
    {
        Megapixels = megapixels;
    }
    public Camera(string id, string name, int manufacturerId, decimal price, double screenSize, int userRating, int megapixels)
        : base(id, name, manufacturerId, price, screenSize, new Camera(megapixels), userRating, null)
    {
        base.Id = "C" + id;
        base.Camera = this;
        Category = "Photo and video";
        Megapixels = megapixels;
    }
}

public class Manufacturer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Manufacturer(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class ProductionReport
{
    public string ManufacturerName { get; set; }
    public IEnumerable<Device>? Devices { get; set; }
}

public class CategoryStats
{
    public string Category { get; set; }
    public int DeviceCount { get; set; }
    public int ManufacturersCount { get; set; }
}