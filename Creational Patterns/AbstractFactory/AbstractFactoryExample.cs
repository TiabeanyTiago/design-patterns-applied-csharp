using DesignPatternsApp.AbstractFactory.Interfaces;

namespace DesignPatternsApp.AbstractFactory
{
    public class AbstractFactoryExample
    {
        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("This is the AbstractFactoryExample Running:");
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
