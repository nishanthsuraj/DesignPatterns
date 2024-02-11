using CodingInterviewSolutions.DesignPatterns.ChainOfResponsibilityPattern.Handler;

namespace CodingInterviewSolutions.DesignPatterns.ChainOfResponsibilityPattern
{
    // This class managed the sequence in which all the handlers are going to be chained together
    // This class initiates the request to a ConcreteHandler object on the chain
    internal class AutomatedTellerMachine
    {
        private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        private OneHundredHandler hundredHandler = new OneHundredHandler();

        public AutomatedTellerMachine()
        {
            // Prepare the chain of Handlers
            // Here, we need to set the next handler of each handler
            twoThousandHandler.SetNextHandler(fiveHundredHandler);
            fiveHundredHandler.SetNextHandler(twoHundredHandler);
            twoHundredHandler.SetNextHandler(hundredHandler);
        }
        // The following method handle the request and passes it to the first handler in the chain of responsibility.
        public void Withdraw(long requestedAmount)
        {
            //First check whether the amount is Divisible by 100 or not
            if (requestedAmount % 100 == 0)
            {
                twoThousandHandler.DispatchNote(requestedAmount);
            }
            else
            {
                Console.WriteLine($"You Enter Invalid Amount: {requestedAmount}");
            }
        }
    }
}
