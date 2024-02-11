using CodingInterviewSolutions.DesignPatterns.DecoratorPattern.Component;

namespace CodingInterviewSolutions.DesignPatterns.DecoratorPattern.ConcreteComponent
{
    internal class Margarita : Pizza
    {
        public override double Cost()
        {
            const int cost = 100;
            return cost;
        }
    }
}
