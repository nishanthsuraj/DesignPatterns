namespace CodingInterviewSolutions.DesignPatterns.MementoPattern
{
    //TransactionMemento - This will store the state of the account.
    public class TransactionMemento
    {
        public decimal Balance { get; }
        public TransactionMemento(decimal balance)
        {
            Balance = balance;
        }

        public void CurrentBalace()
        {
            Console.WriteLine($"Current Balance: ${Balance}");
        }
    }
}
