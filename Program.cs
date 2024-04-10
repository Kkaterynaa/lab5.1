using _2lab5;

class Program
{
    static void Main(string[] args)
    {
        Computer computer = new Computer(100000);
        Console.WriteLine($"Computer price: {computer.Price}");
        computer.Connect();
        computer.Reboot();
        computer.Disconnect();

        Console.WriteLine();

        Laptop laptop = new Laptop(50000);
        Console.WriteLine($"Laptop price: {laptop.Price}");
        laptop.Connect();
        laptop.Reboot();
        laptop.Disconnect();

        Console.WriteLine();

        DesktopPC desktopPC = new DesktopPC(40000);
        Console.WriteLine($"Desktop PC price: {desktopPC.Price}");
        desktopPC.Connect();
        desktopPC.Reboot();
        desktopPC.Disconnect();

        Console.WriteLine();

        NintendoSwitch nintendoSwitch = new NintendoSwitch(30000);
        Console.WriteLine($"Nintendo Switch price: {nintendoSwitch.Price}");
        nintendoSwitch.Connect();
        nintendoSwitch.Reboot();
        nintendoSwitch.Disconnect();

        Console.WriteLine();

        IPhone iPhone = new IPhone(35000);
        Console.WriteLine($"IPhone price: {iPhone.Price}");
        iPhone.Connect();
        iPhone.Reboot(); 
        iPhone.Disconnect();

        Console.WriteLine();

        GooglePixel7 googlePixel7 = new GooglePixel7(30000);
        Console.WriteLine($"Google Pixel 7 price: {googlePixel7.Price}");
        googlePixel7.Connect();
        googlePixel7.Reboot();
        googlePixel7.Disconnect();
    }
}