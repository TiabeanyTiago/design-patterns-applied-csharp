using DesignPatternsApp.CreationalPatterns.AbstractFactory;
using DesignPatternsApp.CreationalPatterns.Builder;
using DesignPatternsApp.CreationalPatterns.Prototype;
using DesignPatternsApp.CreationalPatterns.FactoryMethod;
using DesignPatternsApp.CreationalPatterns.Singleton;
using DesignPatternsApp.StructuralPatterns.Adapter;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Let's run the Creational Patterns Examples:");
        new AbstractFactoryExample().Run();
        new BuilderExample().Run();
        new ChainedBuilderExample().Run();
        new FactoryMethodExample().Run();
        new PrototypeExample().Run();
        new SingletonExample().Run();

        Console.WriteLine("Let's run the Structural Patterns Examples:");
        new AdapterExample().Run();
    }
}