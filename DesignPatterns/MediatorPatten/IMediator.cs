namespace CodingInterviewSolutions.DesignPatterns.MediatorPatten
{
    internal interface IMediator
    {
        void PlaceBid(IBidder bidder, int amount);
    }
}
