using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars.Ford
{
    public class Mustang : Ford
    {
        public Mustang(int productionYear)
            : base(productionYear)
        {
        }

        public override TypeOfBody TypeOfBody => TypeOfBody.Coupe;
        public override Country CreatedCountry => Country.USA;
        public override double MaxSpeed => 250;
        public override double Price => 100500;
        public override TypeOfEngine TypeOfEngine => TypeOfEngine.Gas;
        public override string Model => "Mustang";
        public override double FuelConsumed => 10;
        public override TypeOfTransmision TypeOfTransmision => TypeOfTransmision.Automatic;
    }
}
