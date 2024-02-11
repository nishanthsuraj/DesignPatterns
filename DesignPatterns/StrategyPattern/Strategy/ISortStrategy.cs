namespace CodingInterviewSolutions.DesignPatterns.StrategyPattern.Strategy
{
    internal interface ISortStrategy
    {
        void Sort(IList<string> unsortedList);
    }
}
