namespace CodingInterviewSolutions.DesignPatterns.BridgePattern.Solution
{
    //This is an abstract class that going to be implemented by the Concrete Abstraction
    //It contains a reference to an object of type IMessageSender Interface i.e. messageSender
    //and delegates all of the real work to this object (the class that implements IMessageSender Interface).
    //It can also act as the base class for other abstractions.
    internal abstract class AbstractMessage
    {
        protected IMessageSender MessageSender { get; set; }

        public AbstractMessage(IMessageSender messageSender)
        {
            //Initialize the super class messageSender variable
            MessageSender = messageSender;
        }

        public abstract void SendMessage(string Message);
    }
}
