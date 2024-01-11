using DesignPatternsApp.AbstractFactory;
using DesignPatternsApp.Builder;
using DesignPatternsApp.Creational_Patterns.Builder;
using DesignPatternsApp.Creational_Patterns.Prototype;
using DesignPatternsApp.FactoryMethod;
using DesignPatternsApp.Singleton;

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
    }
}