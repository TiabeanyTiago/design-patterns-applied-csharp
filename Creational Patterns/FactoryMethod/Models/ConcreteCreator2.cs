using DesignPatternsApp.FactoryMethod.Models.Abstracts;
using DesignPatternsApp.FactoryMethod.Models.Interfaces;

namespace DesignPatternsApp.FactoryMethod.Models
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
