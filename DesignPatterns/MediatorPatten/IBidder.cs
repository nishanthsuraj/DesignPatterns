namespace CodingInterviewSolutions.DesignPatterns.MediatorPatten
{
    internal interface IBidder
    {
        public string Name { get; set; }
        void AddBid(int amount);
        void ReceiveBid();
    }
}
