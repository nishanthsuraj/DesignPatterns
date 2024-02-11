using CodingInterviewSolutions.DesignPatterns.DecoratorPattern.Component;
using CodingInterviewSolutions.DesignPatterns.DecoratorPattern.Decorator;

namespace CodingInterviewSolutions.DesignPatterns.DecoratorPattern.ConcreteDecorator
{
    internal class Mushroom : ToppingsDecorator
    {
        public Mushroom(Pizza pizza)
            : base(pizza) { }

        public override double Cost()
        {
            const double cost = 15;
            return Pizza.Cost() + cost;
        }
    }
}
