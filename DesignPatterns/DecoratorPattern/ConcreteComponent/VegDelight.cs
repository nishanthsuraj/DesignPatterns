using CodingInterviewSolutions.DesignPatterns.DecoratorPattern.Component;

namespace CodingInterviewSolutions.DesignPatterns.DecoratorPattern.ConcreteComponent
{
    internal class VegDelight : Pizza
    {
        public override double Cost()
        {
            const int cost = 150;
            return cost;
        }
    }
}
