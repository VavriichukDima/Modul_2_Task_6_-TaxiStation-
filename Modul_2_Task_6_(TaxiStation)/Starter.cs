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
                Console.WriteLine($"Brand: {taxiPark.Cars[i].Brand}, Model: {taxiPark.Cars[i].Model}, Type of engine: {taxiPark.Cars[i].TypeOfEngine}, Country create: {taxiPark.Cars[i].CreatedCountry}, Type of body: {taxiPark.Cars[i].TypeOfBody}, Price: {taxiPark.Cars[i].Price}, Fuel Consumed: {taxiPark.Cars[i].FuelConsumed}");
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine($"Total cost taxiPark: {taxiPark.Cost}");

            Console.WriteLine("--------------------------");
            var someCar = taxiPark.FindCar(Brand.Audi, 100, 9999);
            for (var i = 0; i < taxiPark.Cars.Length; i++)
            {
                Console.WriteLine($"Audi: {taxiPark.Cars[i].Brand} {taxiPark.Cars[i].Model} cost: {taxiPark.Cars[i].Price}");
            }
        }
    }
}
