using CodingInterviewSolutions.DesignPatterns.DecoratorPattern.Component;

namespace CodingInterviewSolutions.DesignPatterns.DecoratorPattern.Decorator
{
    internal abstract class ToppingsDecorator : Pizza
    {
        public Pizza Pizza { get; set; }

        public ToppingsDecorator(Pizza pizza)
        {
            Pizza = pizza;
        }
    }
}
