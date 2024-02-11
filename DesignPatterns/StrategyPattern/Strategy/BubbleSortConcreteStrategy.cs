namespace CodingInterviewSolutions.DesignPatterns.StrategyPattern.Strategy
{
    internal class BubbleSortConcreteStrategy : ISortStrategy
    {
        public void Sort(IList<string> unsortedList)
        {
            // Implement BubbleSort
            Console.WriteLine("BubbleSort");
        }
    }
}
