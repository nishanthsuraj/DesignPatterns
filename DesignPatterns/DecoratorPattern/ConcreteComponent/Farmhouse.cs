using CodingInterviewSolutions.DesignPatterns.DecoratorPattern.Component;

namespace CodingInterviewSolutions.DesignPatterns.DecoratorPattern.ConcreteComponent
{
    internal class Farmhouse : Pizza
    {
        public override double Cost()
        {
            const int cost = 120;
            return cost;
        }
    }
}
