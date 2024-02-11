using CodingInterviewSolutions.DesignPatterns.FactoryPattern.Implementations;
using CodingInterviewSolutions.DesignPatterns.FactoryPattern.Interfaces;

namespace CodingInterviewSolutions.DesignPatterns.FactoryPattern.Factory
{
    internal class ShapeFactory : IShapeFactory
    {
        public IShape Create(string vechicleName)
        {
            return vechicleName.ToLower() switch
            {
                "circle" => new Circle(),
                "rectangle" => new Rectangle(),
                "square" => new Square(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
