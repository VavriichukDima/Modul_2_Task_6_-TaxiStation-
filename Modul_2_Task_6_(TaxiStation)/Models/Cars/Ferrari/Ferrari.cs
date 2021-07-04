using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars.Ferrari
{
    public abstract class Ferrari : Car
    {
        protected Ferrari(int productionYear)
            : base(productionYear)
        {
        }

        public override Brand Brand => Brand.Ferrari;
    }
}
