using DesignPatternsApp.FactoryMethod.Models.Interfaces;

namespace DesignPatternsApp.FactoryMethod.Models
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}

