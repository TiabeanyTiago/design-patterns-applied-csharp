using DesignPatternsApp.FactoryMethod.Models.Interfaces;

namespace DesignPatternsApp.FactoryMethod.Models
{
    // Concrete Products provide various implementations of the Product
    // interface.
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}

