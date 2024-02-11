using CodingInterviewSolutions.DesignPatterns.StrategyPattern.Strategy;

namespace CodingInterviewSolutions.DesignPatterns.StrategyPattern
{
    internal class Context : IContext
    {
        private ISortStrategy SortStrategy { get; set; }
        public IList<string> StudentNames { get; set; }

        public Context()
        {
            StudentNames = new List<string>();
        }

        public void Add(string value)
        {
            StudentNames.Add(value);
        }

        public void SetSortingAlgorithm(ISortStrategy sortStrategy)
        {
            SortStrategy = sortStrategy;
        }

        public void Sort()
        {
            SortStrategy.Sort(StudentNames);
        }
    }
}
