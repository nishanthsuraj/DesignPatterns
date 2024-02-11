namespace CodingInterviewSolutions.DesignPatterns.BridgePattern.Solution
{
    // This is going to be a concrete class that inherits from the Abstraction class i.e. AbstractMessage. 
    // This Concrete Abstraction Class implements the operations defined by AbstractMessage class.
    internal class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void SendMessage(string Message)
        {
            MessageSender.SendMessage(Message);
        }
    }
}
