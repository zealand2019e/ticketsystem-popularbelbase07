using System;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        private double _price;
        private bool _brobizz;
        private string _licensePlate;
        public DateTime Date { get; set; }
        public abstract string VehicleType();

        public virtual double Price
        {
            get { return _price; }
            set
            {
                if (Date.DayOfWeek == DayOfWeek.Sunday && Date.DayOfWeek == DayOfWeek.Saturday)
                {
                    if (_brobizz==true)
                    {
                        _price = -_price - (_price * .05);
                    }

                }
                else
                {
                    _price = value;
                }
            }
        }

        public string LicensePlate
        {


            get { return _licensePlate; }



            set
            {
                if (value.Length > 7)
                {
                    throw new Exception("License plate must be lower than 7 !!");
                }
                else
                {
                    _licensePlate = value;
                }


            }

        }

        protected Vehicle(double price, bool brobizz, string licensePlate, DateTime date)
        {
            _price = price;
            _brobizz = brobizz;
            _licensePlate = licensePlate;
            Date = date;
        }
    }
}
