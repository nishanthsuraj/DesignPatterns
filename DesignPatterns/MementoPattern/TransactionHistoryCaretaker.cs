namespace CodingInterviewSolutions.DesignPatterns.MementoPattern
{
    //TransactionHistory - Manages the saved states of the account.
    public class TransactionHistoryCaretaker
    {
        private Stack<TransactionMemento> _history = new Stack<TransactionMemento>();

        public void SaveState(BankAccountOriginator account)
        {
            _history.Push(account.CreateMemento());
        }

        public TransactionMemento UndoTransaction()
        {
            _history.Pop();
            return _history.Peek();
        }
    }
}
