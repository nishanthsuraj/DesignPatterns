namespace CodingInterviewSolutions.DesignPatterns.MediatorPatten
{
    internal class Bidder : IBidder
    {
        public string Name { get; set; }
        private IMediator Mediator { get; }

        public Bidder(string name, IMediator mediator)
        {
            Name = name;
            Mediator = mediator;
        }

        public void AddBid(int amount)
        {
            Mediator.PlaceBid(this, amount);
        }

        public void ReceiveBid()
        {
            Console.WriteLine($"Bidder {Name} is now receiving notification.");
        }
    }
}
