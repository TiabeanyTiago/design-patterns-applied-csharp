using DesignPatternsApp.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Creational_Patterns.Builder
{
    public class ChainedBuilderExample
    {
        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("This is the ChainedBuilderExample Running:");
            var builder = new ChainedBuilder();

            var firstProduct = builder.AddPartA().AddPartC().AddPartA().Build();

            Console.WriteLine("Chained Builded Product with Part A + Part C + Part A:");
            Console.WriteLine(firstProduct.ListParts());


            var secondProduct = builder.AddPartB().Build();

            Console.WriteLine("Chained Builded Product with only Part B:");
            Console.WriteLine(secondProduct.ListParts());


            var thirdProduct = builder.AddPartA().AddPartB().AddPartC().Build();

            Console.WriteLine("Chained Builded Product with only Part A, B and C:");
            Console.WriteLine(thirdProduct.ListParts());

            Console.WriteLine("All products are differents objects created by the same Builder instance.");
        }
    }
}
