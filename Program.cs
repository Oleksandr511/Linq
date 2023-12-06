namespace R10;
public class Program
{
    public static void Main()
    {

        #region Формування наборів даних
            IEnumerable<Device> devices = new List<Device>{     new Camera("C1", "EOS 5D Mark IV", 3, 2499.99M, 3.2, 5, 30),
                                                                new Camera("C2", "D850", 12, 2999.99M, 3.2, 5, 45),
                                                                new Camera("C3", "Alpha A7 III", 19, 1999.99M, 3.0, 4, 24),
                                                                new Camera("C4", "Lumix GH5", 16, 1799.99M, 3.2, 4, 20),
                                                                new Camera("C5", "X-T4", 4, 1699.99M, 3.0, 5, 26),
                                                                new Camera("C6", "Q2", 8, 4999.99M, 3.68, 5, 47),
                                                                new Camera("C7", "OM-D E-M1 Mark III", 14, 1699.99M, 3.0, 4, 20),
                                                                new Camera("C8", "K-1 Mark II", 17, 1799.99M, 3.2, 4, 36),
                                                                new Camera("C9", "X1D II 50C", 6, 5799.99M, 3.6, 5, 50),

                                                                new MobilePhone("M1", "iPhone 13", 1, 1099.99M, 6.1, new Camera(12), 4, "Nano SIM"),
                                                                new MobilePhone("M2", "Galaxy S21", 18, 999.99M, 6.2, new Camera(16), 4, "Nano SIM"),
                                                                new MobilePhone("M3", "9 Pro", 15, 899.99M, 6.7, new Camera(48), 4, "Nano SIM"),
                                                                new MobilePhone("M4", "Pixel 6", 5, 799.99M, 6.4, new Camera(24), 4, "eSIM"),
                                                                new MobilePhone("M5", "iPhone 11", 1, 699.99M, 6.81, new Camera(108), 4, "Nano SIM"),
                                                                new MobilePhone("M6", "Nord 2", 15, 499.99M, 6.43, new Camera(50), 3, "Nano SIM"),
                                                                new MobilePhone("M7", "Xperia 1 III", 19, 1199.99M, 6.5, new Camera(12), 4, "Nano SIM"),
                                                                new MobilePhone("M8", "M50 Pro", 11, 1299.99M, 6.6, new Camera(40), 4, "Nano SIM"),
                                                                new MobilePhone("M9", "Velvet", 9, 599.99M, 6.8, new Camera(48), 3, "Nano SIM"),
                                                                new MobilePhone("M10", "Edge", 11, 499.99M, 6.7, new Camera(64), 3, "Nano SIM"),

                                                                new Device("D1", "Smartwatch A", 1, 199.99M, 1.2, null, 4, "Wearable"),
                                                                new Device("D2", "Tablet X", 10, 299.99M, 10.1, null, 3, "Tablet"),
                                                                new Device("D3", "Laptop Y", 10, 999.99M, 15.6, null, 5, "Laptop"),
                                                                new Device("D4", "Smart Speaker B", 7, 79.99M, 0.0, null, 4, "Smart Speaker"),
                                                                new Device("D5", "Fitness Tracker C", 18, 49.99M, 0.0, null, 4, "Wearable"),
                                                                new Device("D6", "E-Reader D", 2, 149.99M, 6.0, null, 4, "E-Reader"),
                                                                new Device("D7", "Game Console E", 10, 399.99M, 0.0, null, 4, "Game Console"),
                                                                new Device("D8", "Wireless Earbuds F", 16, 79.99M, 0.0, null, 4, "Audio"),
                                                                new Device("D9", "Portable Charger G", 8, 29.99M, 0.0, null, 4, "Accessories"),
                                                                new Device("D10", "VR Headset H", 5, 299.99M, 0.0, null, 4, "VR Headset"),
                                                                new Device("D11", "Bluetooth Headphones I", 2, 79.99M, 0.0, null, 4, "Audio"),
                                                                new Device("D12", "Smart Home Hub J", 16, 129.99M, 0.0, null, 4, "Smart Home"),
                                                                new Device("D13", "GPS Tracker K", 5, 49.99M, 0.0, null, 3, "Wearable"),
                                                                new Device("D14", "Drone L", 16, 299.99M, 0.0, null, 4, "Gadgets"),
                                                                new Device("D15", "E-Scooter M", 16, 299.99M, 0.0, null, 3, "Transportation"),
                                                                new Device("D16", "Security Camera N", 3, 199.99M, 0.0, null, 4, "Security"),
                                                                new Device("D17", "Kitchen Appliance O", 9, 99.99M, 0.0, null, 3, "Kitchen"),
                                                                new Device("D18", "Action Camera P", 4, 149.99M, 0.0, null, 4, "Camera"),
                                                                new Device("D19", "Digital Watch Q", 2, 59.99M, 0.0, null, 3, "Wearable"),
                                                                new Device("D20", "Robotic Vacuum Cleaner R", 9, 299.99M, 0.0, null, 4, "Home Appliances")        };

            /*IEnumerable<Manufacturer> manufacturers = new List<Manufacturer>{     new Manufacturer(1, "Apple"),
                                                                                    new Manufacturer(2, "Asus"),
                                                                                    new Manufacturer(3, "Canon"),
                                                                                    new Manufacturer(4, "Fujifilm"),
                                                                                    new Manufacturer(5, "Google"),
                                                                                    new Manufacturer(6, "Hasselblad"),
                                                                                    new Manufacturer(7, "HTC"),
                                                                                    new Manufacturer(8, "Leica"),
                                                                                    new Manufacturer(9, "LG"),
                                                                                    new Manufacturer(10, "Microsoft"),
                                                                                    new Manufacturer(11, "Motorola"),
                                                                                    new Manufacturer(12, "Nikon"),
                                                                                    new Manufacturer(13, "Nokia"),
                                                                                    new Manufacturer(14, "Olympus"),
                                                                                    new Manufacturer(15, "OnePlus"),
                                                                                    new Manufacturer(16, "Panasonic"),
                                                                                    new Manufacturer(17, "Pentax"),
                                                                                    new Manufacturer(18, "Samsung"),
                                                                                    new Manufacturer(19, "Sony")          };*/

        #endregion

        #region Вивід в консоль початкової таблиці
            Console.WriteLine("{0,-5} {1,-20} {2,-15} {3,-10} {4,-10} {5,-10} {6,-10} {7,-15}", "ID", "Name", "Manufacturer", "Price", "ScreenSize", "Megapixels", "UserRating", "Category");
            Console.WriteLine(new string('-', 95));

            foreach (var device in devices)
            {
                if (device is Camera camera)
                {
                    Console.WriteLine("{0,-5} {1,-20} {2,-15} {3,-10:C} {4,-10:F1} {5,-10} {6,-10} {7,-15}", camera.Id, camera.Name, camera.ManufacturerId, camera.Price, camera.ScreenSize, camera.Megapixels, camera.UserRating, camera.Category);
                }
                else if (device is MobilePhone mobilePhone)
                {
                    Console.WriteLine("{0,-5} {1,-20} {2,-15} {3,-10:C} {4,-10:F1} {5,-10} {6,-10} {7,-15}", mobilePhone.Id, mobilePhone.Name, mobilePhone.ManufacturerId, mobilePhone.Price, mobilePhone.ScreenSize, mobilePhone.Camera.Megapixels, mobilePhone.UserRating, mobilePhone.Category);
                }
                else
                {
                    Console.WriteLine("{0,-5} {1,-20} {2,-15} {3,-10:C} {4,-10:F1} {5,-10} {6,-10} {7,-15}", device.Id, device.Name, device.ManufacturerId, device.Price, device.ScreenSize, "N/A", device.UserRating, device.Category);
                }
            }
        #endregion

        #region Застосування потрібних запитів методів з LINQ

            IEnumerable<Device> filteredDevices = Tasks.Tasks.Task1_DevicesWithPriceLessThen(devices, 500);
            //IEnumerable<Device> filteredDevices = Tasks.Tasks.Task4_MegapixelsHigherThen(devices, 40); 
            //IEnumerable<Device> filteredDevices = Tasks.Tasks.Task5_ScreenSizeFromRange(devices, 5, 6.2);
            //IEnumerable<Device> filteredDevices = Tasks.Tasks.Task11_CheapestDevicesForEachManufacturer(devices);

        #endregion

        #region Вивід в консоль "відфільтрованої" таблиці
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,-5} {1,-20} {2,-15} {3,-10} {4,-10} {5,-10} {6,-10} {7,-15}", "ID", "Name", "Manufacturer", "Price", "ScreenSize", "Megapixels", "UserRating", "Category");
            Console.WriteLine(new string('-', 95));

            foreach (var device in filteredDevices)
            {
                if (device is Camera camera)
                {
                    Console.WriteLine("{0,-5} {1,-20} {2,-15} {3,-10:C} {4,-10:F1} {5,-10} {6,-10} {7,-15}", camera.Id, camera.Name, camera.ManufacturerId, camera.Price, camera.ScreenSize, camera.Megapixels, camera.UserRating, camera.Category);
                }
                else if (device is MobilePhone mobilePhone)
                {
                    Console.WriteLine("{0,-5} {1,-20} {2,-15} {3,-10:C} {4,-10:F1} {5,-10} {6,-10} {7,-15}", mobilePhone.Id, mobilePhone.Name, mobilePhone.ManufacturerId, mobilePhone.Price, mobilePhone.ScreenSize, mobilePhone.Camera.Megapixels, mobilePhone.UserRating, mobilePhone.Category);
                }
                else
                {
                    Console.WriteLine("{0,-5} {1,-20} {2,-15} {3,-10:C} {4,-10:F1} {5,-10} {6,-10} {7,-15}", device.Id, device.Name, device.ManufacturerId, device.Price, device.ScreenSize, "N/A", device.UserRating, device.Category);
                }
            }
        #endregion
    }
}
