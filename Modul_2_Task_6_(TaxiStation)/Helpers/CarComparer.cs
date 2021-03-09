using System.Collections;
using Modul_2_Task_6__TaxiStation_.Models.Cars;

namespace Modul_2_Task_6__TaxiStation_.Helpers
{
    public class CarComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as Car;
            var y = second as Car;

            if (x.FuelConsumed > y.FuelConsumed)
            {
                return 1;
            }
            else if (x.FuelConsumed < y.FuelConsumed)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
