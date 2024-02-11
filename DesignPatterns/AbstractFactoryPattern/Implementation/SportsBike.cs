using CodingInterviewSolutions.DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace CodingInterviewSolutions.DesignPatterns.AbstractFactoryPattern.Implementation
{
    // The ProductB1 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following SportsBike Product Belongs to the Bike product family
    internal class SportsBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsBike Details..");
        }
    }
}
