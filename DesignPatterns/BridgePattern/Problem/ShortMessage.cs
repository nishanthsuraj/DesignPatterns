namespace CodingInterviewSolutions.DesignPatterns.BridgePattern.Problem
{
    internal class ShortMessage2 : AbstractMessage2
    {
        public override void SendMessage(string Message)
        {
            Console.WriteLine("Send Short Message");
        }
    }
}
