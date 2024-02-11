using System.Collections.Concurrent;

namespace CodingInterviewSolutions.DesignPatterns.MediatorPatten
{
    internal class Mediator : IMediator
    {
        private readonly ConcurrentDictionary<IBidder, int> bidders;

        public Mediator()
        {
            bidders = new ConcurrentDictionary<IBidder, int>();
        }

        #region IMediator Implementation
        public void PlaceBid(IBidder bidder, int amount)
        {
            AddBid(bidder, amount);
        }
        #endregion

        #region Private Methods
        private void AddBid(IBidder bidder, int amount)
        {
            if (!bidders.ContainsKey(bidder))
                bidders.TryAdd(bidder, amount);
            else
            {
                bidders[bidder] = amount;
            }
            Console.WriteLine($"Bidder {bidder.Name} has placed a bid of: ${amount}");
            SendNotifications(bidder.Name);
        }

        private void SendNotifications(string exceptBidderName)
        {
            foreach (KeyValuePair<IBidder, int> bidder in bidders)
            {
                if (bidder.Key.Name != exceptBidderName)
                {
                    bidder.Key.ReceiveBid();
                }
            }
        }
        #endregion
    }
}
