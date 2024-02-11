using CodingInterviewSolutions.DesignPatterns.FactoryPattern.Interfaces;

namespace CodingInterviewSolutions.DesignPatterns.FactoryPattern.Factory
{
    internal interface IShapeFactory
    {
        IShape Create(string shapeName);
    }
}
