using DesignPatternsApp.CreationalPatterns.FactoryMethod.Models;
using DesignPatternsApp.CreationalPatterns.FactoryMethod.Models.Abstracts;
using DesignPatternsApp.CreationalPatterns.FactoryMethod.Models.Interfaces;

namespace DesignPatternsApp.CreationalPatterns.FactoryMethod
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
