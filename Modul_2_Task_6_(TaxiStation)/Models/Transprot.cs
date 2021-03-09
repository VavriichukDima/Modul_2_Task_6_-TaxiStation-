using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models
{
    public abstract class Transprot
    {
        protected Transprot(CarBrand carBrand, string carModel, TypeOfEngine typeOfEngine, Color carColor, Country createdCountry, TypeOfBody typeOfBody, double cost, double fuelConsumed)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            TypeOfEngine = typeOfEngine;
            CarColor = carColor;
            CreatedCountry = createdCountry;
            TypeOfBody = typeOfBody;
            Cost = cost;
            FuelConsumed = fuelConsumed;
        }

        public CarBrand CarBrand { get; }
        public string CarModel { get; }
        public TypeOfEngine TypeOfEngine { get; }
        public Color CarColor { get; }
        public Country CreatedCountry { get; }
        public TypeOfBody TypeOfBody { get; }
        public double Cost { get; }
        public double FuelConsumed { get; }
    }
}
