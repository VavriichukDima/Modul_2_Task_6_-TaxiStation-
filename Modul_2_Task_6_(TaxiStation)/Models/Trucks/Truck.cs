using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models
{
    public abstract class Truck : Transprot
    {
        protected Truck(int productionYear)
            : base(productionYear)
        {
        }

        public override TypeOfTransport TypeOfTransport => TypeOfTransport.Truck;
        public override NumOfWheel NumOfWeel => NumOfWheel._12;
        public TypeOfEngine TypeOfEngine => TypeOfEngine.Diesel;
        public TypeOfBody TypeOfBody => TypeOfBody.Truck;
        public abstract double FuelConsumed { get; }
        public abstract TypeOfTransmision TypeOfTransmision { get; }
        public abstract double Carrying { get; }
    }
}
