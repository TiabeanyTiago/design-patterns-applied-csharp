using DesignPatternsApp.AbstractFactory.Interfaces;
using static DesignPatternsApp.AbstractFactory.AbstractFactoryExample;

namespace DesignPatternsApp.AbstractFactory.Models
{
    class ConcreteProductA2 : IProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
