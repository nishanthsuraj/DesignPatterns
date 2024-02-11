namespace CodingInterviewSolutions.DesignPatterns.ObserverPattern.Subject
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    internal class IBM : Stock
    {
        // Constructor
        public IBM(string symbol, double price)
            : base(symbol, price)
        {
        }
    }
}
