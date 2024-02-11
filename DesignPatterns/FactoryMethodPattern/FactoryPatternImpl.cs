using CodingInterviewSolutions.DesignPatterns.FactoryPattern.Factory;
using CodingInterviewSolutions.DesignPatterns.FactoryPattern.Interfaces;

namespace CodingInterviewSolutions.DesignPatterns.FactoryPattern
{
    internal class FactoryPatternImpl
    {
        public void Execute(string shapeName)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape = shapeFactory.Create(shapeName);
            shape.Run();
        }
    }
}
