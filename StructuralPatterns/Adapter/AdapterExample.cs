using DesignPatternsApp.StructuralPatterns.Adapter.Interfaces;
using DesignPatternsApp.StructuralPatterns.Adapter.Models;

namespace DesignPatternsApp.StructuralPatterns.Adapter
{
    public class AdapterExample
    {
        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("This is the AdapterExample Running:");
            Adaptee adaptee = new Adaptee();
            ITarget target = new AdapterImplementation(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }

    }
}
