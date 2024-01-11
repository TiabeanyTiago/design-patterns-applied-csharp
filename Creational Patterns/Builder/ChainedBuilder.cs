using DesignPatternsApp.Builder.Interfaces;
using DesignPatternsApp.Builder.Models;

namespace DesignPatternsApp.Builder
{
    public class ChainedBuilder
    {
        private Product _product = new Product();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public ChainedBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public ChainedBuilder AddPartA()
        {
            _product.Add("PartA1");
            return this;
        }

        public ChainedBuilder AddPartB()
        {
            _product.Add("PartB1");
            return this;
        }

        public ChainedBuilder AddPartC()
        {
            _product.Add("PartC1");
            return this;
        }

        public Product Build()
        {
            Product result = _product;

            Reset();

            return result;
        }
    }
}
