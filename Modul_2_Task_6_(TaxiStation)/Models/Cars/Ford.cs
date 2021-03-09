using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars
{
    public class Ford : Car
    {
        public Ford(CarBrand carBrand, string carModel, TypeOfEngine typeOfEngine, Color carColor, Country createdCountry, TypeOfBody typeOfBody, double cost, double fuelConsumed)
            : base(carBrand, carModel, typeOfEngine, carColor, createdCountry, typeOfBody, cost, fuelConsumed)
        {
        }

        public override int NumberOfPassangers => 4;
    }
}
