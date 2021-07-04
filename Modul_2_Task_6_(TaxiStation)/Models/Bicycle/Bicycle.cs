using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Bicycle
{
    public abstract class Bicycle : Transprot
    {
        protected Bicycle(int productionYear)
            : base(productionYear)
        {
        }

        public override TypeOfTransport TypeOfTransport => TypeOfTransport.Bicycle;
        public override NumOfWheel NumOfWeel => NumOfWheel._2;
        public abstract TypeOfEngine TypeOfEngine { get; }
        public abstract TypeOfBody TypeOfBody { get; }
        public abstract double FuelConsumed { get; }
        public abstract TypeOfTransmision TypeOfTransmision { get; }
    }
}
