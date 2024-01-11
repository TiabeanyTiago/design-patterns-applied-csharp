using DesignPatternsApp.AbstractFactory.Interfaces;
using static DesignPatternsApp.AbstractFactory.AbstractFactoryExample;

namespace DesignPatternsApp.AbstractFactory.Models
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
