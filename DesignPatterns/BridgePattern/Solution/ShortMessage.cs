namespace CodingInterviewSolutions.DesignPatterns.BridgePattern.Solution
{
    // This is going to be a concrete class which inherits from the Abstraction class i.e. AbstractMessage. 
    // This Concrete Abstraction Class implements the operations defined by AbstractMessage class.
    internal class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void SendMessage(string Message)
        {
            if (Message.Length <= 10)
            {
                MessageSender.SendMessage(Message);
            }
            else
            {
                Console.WriteLine("Unable to send the message as length > 10 characters");
            }
        }
    }
}
