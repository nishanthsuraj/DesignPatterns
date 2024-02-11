using CodingInterviewSolutions.DesignPatterns.StrategyPattern.Strategy;

namespace CodingInterviewSolutions.DesignPatterns.StrategyPattern
{
    internal interface IContext
    {
        void Add(string value);
        void SetSortingAlgorithm(ISortStrategy sortStrategy);
        void Sort();
    }
}
