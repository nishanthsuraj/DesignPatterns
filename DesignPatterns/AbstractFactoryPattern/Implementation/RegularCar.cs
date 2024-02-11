using CodingInterviewSolutions.DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace CodingInterviewSolutions.DesignPatterns.AbstractFactoryPattern.Implementation
{
    // The ProductA2 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following RegularCar Product Belongs to the Car product family
    internal class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularCar Details..");
        }
    }
}
