using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars.Ferrari
{
        public class F8_Tributo : Ferrari
        {
            public F8_Tributo(int productionYear)
                : base(productionYear)
            {
            }

            public override TypeOfBody TypeOfBody => TypeOfBody.Coupe;
            public override Country CreatedCountry => Country.Italy;
            public override double MaxSpeed => 230;
            public override double Price => 1000000;
            public override TypeOfEngine TypeOfEngine => TypeOfEngine.Gas;
            public override string Model => "F8";
            public override double FuelConsumed => 15;
            public override TypeOfTransmision TypeOfTransmision => TypeOfTransmision.Automatic;
        }
}
