using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars.Ford
{
    public class Mondeo : Ford
    {
        public Mondeo(int productionYear)
            : base(productionYear)
        {
        }

        public override TypeOfBody TypeOfBody => TypeOfBody.Sedan;
        public override Country CreatedCountry => Country.USA;
        public override double MaxSpeed => 199;
        public override double Price => 159000;
        public override TypeOfEngine TypeOfEngine => TypeOfEngine.Gas;
        public override string Model => "Mondeo";
        public override double FuelConsumed => 7.7;
        public override TypeOfTransmision TypeOfTransmision => TypeOfTransmision.Manual;
    }
}
