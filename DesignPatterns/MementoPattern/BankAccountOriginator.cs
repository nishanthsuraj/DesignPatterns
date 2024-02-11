namespace CodingInterviewSolutions.DesignPatterns.MementoPattern
{
    //BankAccount - Represents a bank account. 
    //It can create a memento and restore its state from a memento.
    public class BankAccountOriginator
    {
        public decimal Balance { get; private set; }

        public BankAccountOriginator(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Deposited ammount: ${amount}");
            Balance += amount;
            CurrentBalace();
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrew ammount: ${amount}");
            Balance -= amount;
            CurrentBalace();
        }

        public void CurrentBalace()
        {
            Console.WriteLine($"Current Balance: ${Balance}");
        }

        public TransactionMemento CreateMemento()
        {
            return new TransactionMemento(Balance);
        }

        public void RestoreFromMemento(TransactionMemento memento)
        {
            Console.WriteLine($"Reverting previous transaction");
            this.Balance = memento.Balance;
        }
    }
}
