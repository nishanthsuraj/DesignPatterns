namespace CodingInterviewSolutions.DesignPatterns.StrategyPattern.Strategy
{
    internal class QuickSortConcreteStrategy : ISortStrategy
    {
        public void Sort(IList<string> unsortedList)
        {
            // Implement BubbleSort
            Console.WriteLine("QuickSort");
        }
    }
}
