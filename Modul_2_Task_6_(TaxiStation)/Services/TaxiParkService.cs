using Modul_2_Task_6__TaxiStation_.Models.Reults;
using Modul_2_Task_6__TaxiStation_.Models.Enums;
using Modul_2_Task_6__TaxiStation_.Models.Cars;
using Modul_2_Task_6__TaxiStation_.Models;

namespace Modul_2_Task_6__TaxiStation_.Services
{
    public class TaxiParkService : ITaxiParkService
    {
        public TaxiParkService()
        {
        }

        public TaxiPark MakeTaxiPark()
        {
            var car = new Car[]
            {
                new Audi(CarBrand.Audi, "A7", TypeOfEngine.Gas, Color.Green, Country.Germany, TypeOfBody.Sedan, 150, 10),
                new Ferrari(CarBrand.Ferrari, "F1", TypeOfEngine.Gas, Color.Red, Country.Italy, TypeOfBody.Coupe, 300, 9),
                new Ford(CarBrand.Ford, "Focus", TypeOfEngine.Diesel, Color.Blue, Country.USA, TypeOfBody.Hatchback, 100, 19),
                new Mazda(CarBrand.Mazda, "RX7", TypeOfEngine.Gas, Color.White, Country.Japan, TypeOfBody.Universal, 145, 15),
                new Lanos(CarBrand.Lanos, "Lanos", TypeOfEngine.Electro, Color.Black, Country.Ukraine, TypeOfBody.Sedan, 100500, 1)
            };

            var cost = 0.0;
            for (var i = 0; i < car.Length; i++)
            {
                cost += car[i].Cost;
            }

            return new TaxiPark { Cars = car, Cost = cost };
        }
    }
}
