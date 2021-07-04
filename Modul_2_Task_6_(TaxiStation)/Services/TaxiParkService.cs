using Modul_2_Task_6__TaxiStation_.Models.Reults;
using Modul_2_Task_6__TaxiStation_.Models.Cars.Mazda;
using Modul_2_Task_6__TaxiStation_.Models.Cars.Audi;
using Modul_2_Task_6__TaxiStation_.Models.Cars.Ferrari;
using Modul_2_Task_6__TaxiStation_.Models.Cars.Ford;
using Modul_2_Task_6__TaxiStation_.Models.Cars;

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
                new CX7(2015),
                new A7(2016),
                new Q7(2017),
                new F8_Tributo(2018),
                new Mondeo(2019),
                new Mustang(2020),
            };

            var cost = 0.0;
            for (var i = 0; i < car.Length; i++)
            {
                cost += car[i].Price;
            }

            return new TaxiPark { Cars = car, Cost = cost };
        }
    }
}
