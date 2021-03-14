using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars.Audi
{
    public class A7 : Audi
    {
        public A7(int productionYear)
            : base(productionYear)
        {
        }

        public override TypeOfBody TypeOfBody => TypeOfBody.Sedan;
        public override Country CreatedCountry => Country.Germany;
        public override double MaxSpeed => 305;
        public override double Price => 70000;
        public override TypeOfEngine TypeOfEngine => TypeOfEngine.Gas;
        public override string Model => "A7";
        public override double FuelConsumed => 8.2;
        public override TypeOfTransmision TypeOfTransmision => TypeOfTransmision.Automatic;
    }
}
