using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab5
{
    internal interface IGadget
    {
        void Connect();
        void Disconnect();
        void Reboot();
    }
    class Gadgets : IGadget
    {
        public double Price { get; set; }

        public Gadgets(double price)
        {
            Price = price;
        }

        public virtual void Connect()
        {
            Console.WriteLine("Connecting components...");
        }

        public virtual void Disconnect()
        {
            Console.WriteLine("Disconnecting components...");
        }

        public virtual void Reboot()
        {
            Console.WriteLine("Rebooting gadget...");
        }
    }
    class Computer : Gadgets
    {
        public Computer(double price) : base(price) { }

        public override void Connect()
        {
            Console.WriteLine("Connecting computer components...");
        }
        public override void Reboot()
        {
            Console.WriteLine("Rebooting computer...");
        }
    }

    class Laptop : Gadgets
    {
        public Laptop(double price) : base(price) { }

        public override void Connect()
        {
            Console.WriteLine("Connecting laptop components...");
        }
    }

    class DesktopPC : Gadgets
    {
        public DesktopPC(double price) : base(price) { }
        public override void Disconnect()
        {
            Console.WriteLine("Disconnecting desktop PC components...");
        }
    }

    class NintendoSwitch : Gadgets
    {
        public NintendoSwitch(double price) : base(price) { }
    }

    class Smartphone : Gadgets
    {
        public Smartphone(double price) : base(price) { }
    }

    class IPhone : Smartphone
    {
        public IPhone(double price) : base(price) { }
    }

    class GooglePixel7 : Smartphone
    {
        public GooglePixel7(double price) : base(price) { }
    }
}
