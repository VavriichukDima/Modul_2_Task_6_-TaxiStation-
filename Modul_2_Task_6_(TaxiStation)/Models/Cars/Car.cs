using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars
{
    public abstract class Car : Transprot
    {
        protected Car(int productionYear)
            : base(productionYear)
        {
        }

        public override TypeOfTransport TypeOfTransport => TypeOfTransport.Car;
        public override NumOfWheel NumOfWeel => NumOfWheel._4;
        public abstract TypeOfEngine TypeOfEngine { get; }
        public abstract TypeOfBody TypeOfBody { get; }
        public abstract double FuelConsumed { get; }
        public abstract TypeOfTransmision TypeOfTransmision { get; }
    }
}
