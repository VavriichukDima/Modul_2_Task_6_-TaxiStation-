using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars.Audi
{
    public abstract class Audi : Car
    {
        protected Audi(int productionYear)
            : base(productionYear)
        {
        }

        public override Brand Brand => Brand.Audi;
    }
}
