namespace DesignPatternsApp.Singleton
{
    public class SingletonExample
    {
        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("This is the SingletonExample Running:");
            // The client code.
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
                s1.SomeBusinessLogic();
                s2.SomeBusinessLogic();
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
