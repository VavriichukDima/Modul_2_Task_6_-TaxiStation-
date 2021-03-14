using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars.Mazda
{
    public class CX7 : Mazda
    {
        public CX7(int productionYear)
            : base(productionYear)
        {
        }

        public override TypeOfBody TypeOfBody => TypeOfBody.Universal;
        public override Country CreatedCountry => Country.Japan;
        public override double MaxSpeed => 180;
        public override double Price => 357000;
        public override TypeOfEngine TypeOfEngine => TypeOfEngine.Diesel;
        public override string Model => "CX7";
        public override double FuelConsumed => 8.8;
        public override TypeOfTransmision TypeOfTransmision => TypeOfTransmision.Manual;
    }
}
