using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models
{
    public abstract class Transprot
    {
        protected Transprot(int productionYear)
        {
            ProductionYear = productionYear;
        }

        public abstract TypeOfTransport TypeOfTransport { get; }
        public abstract Brand Brand { get; }
        public abstract string Model { get; }
        public abstract double MaxSpeed { get; }
        public abstract NumOfWheel NumOfWeel { get; }
        public abstract double Price { get; }
        public abstract Country CreatedCountry { get; }
        public int ProductionYear { get; }
    }
}
