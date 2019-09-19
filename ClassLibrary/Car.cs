using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Vehicle
    {

        public  double Price()
        {
            return 240;
        }


        public override string VehicleType()
        {
            return "Car";
        }

        public Car(double price, bool brobizz, string licensePlate, DateTime date) : base(price, brobizz, licensePlate, date)
        {
        }
    }
}


