using CodingInterviewSolutions.DesignPatterns.DecoratorPattern.Component;
using CodingInterviewSolutions.DesignPatterns.DecoratorPattern.Decorator;

namespace CodingInterviewSolutions.DesignPatterns.DecoratorPattern.ConcreteDecorator
{
    internal class ExtraCheese : ToppingsDecorator
    {

        public ExtraCheese(Pizza pizza)
            : base(pizza)
        {
        }

        public override double Cost()
        {
            const double cost = 10;
            return Pizza.Cost() + cost;
        }
    }
}
