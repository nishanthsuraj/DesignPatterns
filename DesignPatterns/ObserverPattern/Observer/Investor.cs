using CodingInterviewSolutions.DesignPatterns.ObserverPattern.Subject;

namespace CodingInterviewSolutions.DesignPatterns.ObserverPattern.Observer
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    internal class Investor : IInvestor
    {
        private string name;
        // Constructor
        public Investor(string name)
        {
            this.name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                "change to $ {2}", name, stock.Symbol, stock.Price);
        }
    }
}
