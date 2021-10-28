using System;

namespace ModuleHW.BridgePattern
{
    public class Starter
    {
        public void Run()
        {
            Console.WriteLine($"Bridge Design Pattern output...\n");

            var client = new Client();

            Abstraction abstraction;

            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}
