using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars
{
    public abstract class Car : Transprot
    {
        protected Car(CarBrand carBrand, string carModel, TypeOfEngine typeOfEngine, Color carColor, Country createdCountry, TypeOfBody typeOfBody, double cost, double fuelConsumed)
            : base(carBrand, carModel, typeOfEngine, carColor, createdCountry, typeOfBody, cost, fuelConsumed)
        {
        }

        public abstract int NumberOfPassangers { get; }
    }
}
