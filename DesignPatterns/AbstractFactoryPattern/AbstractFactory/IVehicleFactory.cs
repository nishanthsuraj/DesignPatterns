using CodingInterviewSolutions.DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace CodingInterviewSolutions.DesignPatterns.AbstractFactoryPattern.AbstractFactory
{
    // The AbstractFactory interface
    // The Abstract Factory interface declares a set of methods that return different abstract products. 
    // These products are called a family. 
    // A family of products may have several variants
    internal interface IVehicleFactory
    {
        //Abstract Product A
        IBike CreateBike();
        //Abstract Product B
        ICar CreateCar();
    }
}
