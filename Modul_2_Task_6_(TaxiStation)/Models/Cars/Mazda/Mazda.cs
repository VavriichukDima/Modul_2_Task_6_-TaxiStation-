using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars.Mazda
{
    public abstract class Mazda : Car
    {
        protected Mazda(int productionYear)
             : base(productionYear)
        {
        }

        public override Brand Brand => Brand.Mazda;
    }
}
