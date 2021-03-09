using Modul_2_Task_6__TaxiStation_.Models.Cars;
using Modul_2_Task_6__TaxiStation_.Models.Enums;
using Modul_2_Task_6__TaxiStation_.Models.Reults;

namespace Modul_2_Task_6__TaxiStation_.Helpers
{
    public static class CarExtention
    {
        public static Car[] FindCar(this TaxiPark taxiPark, CarBrand carBrand, double minCost, double maxCost)
        {
            var temp = new Car[taxiPark.Cars.Length];
            for (var i = 0; i < temp.Length; i++)
            {
                var item = taxiPark.Cars[i];
                if (item.CarBrand == carBrand && item.Cost > minCost && item.Cost < maxCost)
                {
                    temp[i] = taxiPark.Cars[i];
                }
            }

            var tempResult = ArrayHelper.CleanCapacity(temp);

            var result = new Car[tempResult.Length];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = tempResult[i] as Car;
            }

            return result;
        }
    }
}
