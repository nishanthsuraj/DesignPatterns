namespace CodingInterviewSolutions.DesignPatterns.ChainOfResponsibilityPattern.Handler
{
    // Handler Abstract Class
    // The Default Chaining Behavior can be implemented inside the abstract handler class.
    internal abstract class CurrencyHandler
    {
        //The NextHandler will hold the reference of the next handler
        public CurrencyHandler NextHandler;
        //Initializing NextHandler reference using the class constructor
        public void SetNextHandler(CurrencyHandler NextHandler)
        {
            this.NextHandler = NextHandler;
        }
        //The following Method needs to be implemented by the Child handler Classes
        //The following method is going to handle a request.
        public abstract void DispatchNote(long requestedAmount);
    }
}
