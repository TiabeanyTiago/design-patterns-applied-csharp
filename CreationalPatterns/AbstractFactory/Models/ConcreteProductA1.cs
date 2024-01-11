using DesignPatternsApp.CreationalPatterns.AbstractFactory.Interfaces;
using static DesignPatternsApp.CreationalPatterns.AbstractFactory.AbstractFactoryExample;

namespace DesignPatternsApp.CreationalPatterns.AbstractFactory.Models
{
    // Concrete Products are created by corresponding Concrete Factories.
    class ConcreteProductA1 : IProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
