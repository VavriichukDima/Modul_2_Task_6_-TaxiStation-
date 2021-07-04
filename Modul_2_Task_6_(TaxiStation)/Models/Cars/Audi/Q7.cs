using Modul_2_Task_6__TaxiStation_.Models.Enums;

namespace Modul_2_Task_6__TaxiStation_.Models.Cars.Audi
{
    public class Q7 : Audi
    {
        public Q7(int productionYear)
            : base(productionYear)
        {
        }

        public override TypeOfBody TypeOfBody => TypeOfBody.Crossover;
        public override Country CreatedCountry => Country.Germany;
        public override double MaxSpeed => 225;
        public override double Price => 120000;
        public override TypeOfEngine TypeOfEngine => TypeOfEngine.Diesel;
        public override string Model => "Q7";
        public override double FuelConsumed => 6.3;
        public override TypeOfTransmision TypeOfTransmision => TypeOfTransmision.Automatic;
    }
}
