using CodingInterviewSolutions.DesignPatterns.ObserverPattern.Subject;

namespace CodingInterviewSolutions.DesignPatterns.ObserverPattern.Observer
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    internal interface IInvestor
    {
        void Update(Stock stock);
    }
}
