using DesignPatternsApp.CreationalPatterns.AbstractFactory.Interfaces;
using static DesignPatternsApp.CreationalPatterns.AbstractFactory.AbstractFactoryExample;

namespace DesignPatternsApp.CreationalPatterns.AbstractFactory.Models
{
    class ConcreteProductA2 : IProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
