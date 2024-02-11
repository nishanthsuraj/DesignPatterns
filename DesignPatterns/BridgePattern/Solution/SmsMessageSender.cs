namespace CodingInterviewSolutions.DesignPatterns.BridgePattern.Solution
{
    // This is going to be a class that implements the Implementor Interface i.e. IMessageSender
    // It also provides the implementation details for the associated Abstraction class 
    // Each Concrete Implementation corresponds to a specific platform, in this case sending messages using SMS
    internal class SmsMessageSender : IMessageSender
    {
        public void SendMessage(string Message)
        {
            //Send a message using SMS
            Console.WriteLine("'" + Message + "'   : This Message has been sent using SMS");
        }
    }
}
