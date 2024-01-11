﻿using DesignPatternsApp.CreationalPatterns.AbstractFactory.Interfaces;
using DesignPatternsApp.CreationalPatterns.AbstractFactory.Models;

namespace DesignPatternsApp.CreationalPatterns.AbstractFactory
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
    class ConcreteFactory1 : IFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
