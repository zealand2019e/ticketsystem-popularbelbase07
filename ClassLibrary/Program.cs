using System;

namespace ClassLibrary
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Car cr = new Car();
            cr.Price();
            cr.VehicleType();
            MC mc =new MC();
            mc.Price();
            mc.VehicleType();
        }
    }
}
