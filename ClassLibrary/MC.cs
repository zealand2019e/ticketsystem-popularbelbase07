using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public class MC :Car
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

        public  decimal Price()
        {
            return 125;

        }

        public string VehicleType()
        {
            return "MC";
        }

    }
}
