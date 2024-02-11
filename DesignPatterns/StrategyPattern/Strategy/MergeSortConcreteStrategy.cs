namespace CodingInterviewSolutions.DesignPatterns.StrategyPattern.Strategy
{
    internal class MergeSortConcreteStrategy : ISortStrategy
    {
        public void Sort(IList<string> unsortedList)
        {
            // Implement BubbleSort
            Console.WriteLine("MergeSort");
        }
    }
}
