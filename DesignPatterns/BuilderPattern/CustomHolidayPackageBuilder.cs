namespace CodingInterviewSolutions.DesignPatterns.BuilderPattern
{
    //Concrete Builder: CustomHolidayPackageBuilder
    internal class CustomHolidayPackageBuilder : HolidayPackageBuilder
    {
        public override void BookFlight(string flightDetails)
        {
            Package.Flight = flightDetails;
        }

        public override void BookHotel(string hotelName)
        {
            Package.Hotel = hotelName;
        }

        public override void RentCar(string carDetails)
        {
            Package.CarRental = carDetails;
        }

        public override void AddExcursion(string excursion)
        {
            Package.Excursions.Add(excursion);
        }
    }
}
