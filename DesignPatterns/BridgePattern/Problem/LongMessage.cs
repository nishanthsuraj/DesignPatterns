namespace CodingInterviewSolutions.DesignPatterns.BridgePattern.Problem
{
    internal class LongMessage2 : AbstractMessage2
    {
        public override void SendMessage(string Message)
        {
            Console.WriteLine("Send Long Message");
        }
    }
}
