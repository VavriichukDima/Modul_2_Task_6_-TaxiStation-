using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars.Ford
{
    public abstract class Ford : Car
    {
        protected Ford(int productionYear)
            : base(productionYear)
        {
        }

        public override Brand Brand => Brand.Ford;
    }
}
