using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC : Vehicle
    {
        public override string VehicleType()
        {
            return "Motor Cycle";
        }

        public double Price()
        {
            return 125;
        }

        public MC(double price, bool brobizz, string licensePlate, DateTime date) : base(price, brobizz, licensePlate, date)
        {
        }
    }
}
