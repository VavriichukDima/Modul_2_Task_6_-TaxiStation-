using System;
using Modul_2_Task_6__TaxiStation_.Services;
using Modul_2_Task_6__TaxiStation_.Helpers;
using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_
{
    public class Starter
    {
        private readonly ITaxiParkService _taxiParkService;

        public Starter()
        {
            _taxiParkService = new TaxiParkService();
        }

        public void Run()
        {
            TaxiPark();
        }

        public void TaxiPark()
        {
            var taxiPark = _taxiParkService.MakeTaxiPark();
            Array.Sort(taxiPark.Cars, new CarComparer());

            for (var i = 0; i < taxiPark.Cars.Length; i++)
            {
                Console.WriteLine($"{taxiPark.Cars[i].CarBrand}, {taxiPark.Cars[i].CarModel}, {taxiPark.Cars[i].TypeOfEngine}, {taxiPark.Cars[i].CreatedCountry}, {taxiPark.Cars[i].TypeOfBody}, {taxiPark.Cars[i].Cost}, {taxiPark.Cars[i].FuelConsumed}");
            }

            Console.WriteLine($"Total cost taxiPark: {taxiPark.Cost}");

            var someCar = taxiPark.FindCar(CarBrand.Audi, 100, 9999);
            for (var i = 0; i < taxiPark.Cars.Length; i++)
            {
                Console.WriteLine($"Audi: {taxiPark.Cars[i].CarBrand} {taxiPark.Cars[i].CarModel} cost: {taxiPark.Cars[i].Cost}");
            }
        }
    }
}
