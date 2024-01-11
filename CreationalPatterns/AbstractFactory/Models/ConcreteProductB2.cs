﻿using DesignPatternsApp.CreationalPatterns.AbstractFactory.Interfaces;
using static DesignPatternsApp.CreationalPatterns.AbstractFactory.AbstractFactoryExample;

namespace DesignPatternsApp.CreationalPatterns.AbstractFactory.Models
{
    class ConcreteProductB2 : IProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }

        // The variant, Product B2, is only able to work correctly with the
        // variant, Product A2. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string AnotherUsefulFunctionB(IProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}
