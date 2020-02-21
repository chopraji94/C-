using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAssignment
{
    public abstract class Laptop
    {
        public abstract void Brand();
        public abstract void Price();
        public abstract void Processor();
        public abstract void RAM();
        public abstract void HardDrive();
    }
    public class HP : Laptop
    {
        public override void Brand()

        {
            string name = Console.ReadLine();
            System.Diagnostics.Debug.WriteLine("Brand Name: " + name);
        }
        public override void Price()
        {
            System.Diagnostics.Debug.WriteLine("30000");
        }
        public override void Processor()
        {
            System.Diagnostics.Debug.WriteLine("i7");
        }
        public override void RAM()
        {
            System.Diagnostics.Debug.WriteLine("8GB");
        }
        public override void HardDrive()
        {
            System.Diagnostics.Debug.WriteLine("2TB");
        }
    }
    public class Apple : Laptop
    {
        public override void Brand()

        {
            string name = Console.ReadLine();
            System.Diagnostics.Debug.WriteLine("Brand name:" + name);

        }
        public override void Price()
        {
            System.Diagnostics.Debug.WriteLine("60000");
        }
        public override void Processor()
        {
            System.Diagnostics.Debug.WriteLine("i7");
        }
        public override void RAM()
        {
            System.Diagnostics.Debug.WriteLine("8GB");
        }
        public override void HardDrive()
        {
            System.Diagnostics.Debug.WriteLine("2TB");
        }
    }
    public class Test
    {
        public static void Main(string[] args)
        {

            Laptop l;
            if (name.Equals("hp"))
            {
                l = new HP();
                l.Brand();
                l.Price();
                l.Processor();
                l.RAM();
                l.HardDrive();
            }
            else if (name.Equals("apple"))
            {
                l = new Apple();
                l.Brand();
                l.Price();
                l.Processor();
                l.RAM();
                l.HardDrive();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Brand Not Available");
            }
        }
    }
}
  
