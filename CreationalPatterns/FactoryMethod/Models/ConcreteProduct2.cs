﻿using DesignPatternsApp.CreationalPatterns.FactoryMethod.Models.Interfaces;

namespace DesignPatternsApp.CreationalPatterns.FactoryMethod.Models
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}

