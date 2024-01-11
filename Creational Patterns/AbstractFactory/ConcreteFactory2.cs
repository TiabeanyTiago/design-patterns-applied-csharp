using DesignPatternsApp.AbstractFactory.Interfaces;
using DesignPatternsApp.AbstractFactory.Models;

namespace DesignPatternsApp.AbstractFactory
{
    // Each Concrete Factory has a corresponding product variant.
    class ConcreteFactory2 : IFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
