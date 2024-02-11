namespace CodingInterviewSolutions.DesignPatterns.BuilderPattern
{
    //Builder (Abstract Builder)
    internal abstract class HolidayPackageBuilder
    {
        protected HolidayPackage Package { get; private set; } = new HolidayPackage();

        public abstract void BookFlight(string flightDetails);
        public abstract void BookHotel(string hotelName);
        public abstract void RentCar(string carDetails);
        public abstract void AddExcursion(string excursion);

        public HolidayPackage GetPackage() => Package;
    }
}
