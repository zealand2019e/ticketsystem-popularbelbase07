using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car
    {

        /// <summary>
        /// Properties for car class.
        /// </summary>
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Public method for the price and vehicleType.
        /// </summary>
        /// <returns></returns>

        public decimal Price()
        {
            return 240;

        }

        public string VehicleType()
        {
            return "Car";
        }

    }
}

