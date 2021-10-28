using System;

namespace ModuleHW.CompositePattern
{
    public class Starter
    {
        public void Run()
        {
            Console.WriteLine($"Composite Design Pattern output...\n");

            var client = new Client();

            var leaf = new Leaf();
            Console.Write("Client: I get a simple component - Leaf!\n");
            client.ClientCode(leaf);

            var tree = new Composite();

            var branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());

            Composite branch2 = new Composite();
            branch2.Add(new Leaf());

            tree.Add(branch1);
            tree.Add(branch2);
            Console.Write("Client: I get a composite component - Tree!\n");
            client.ClientCode(tree);

            Console.Write("Client: I get mixed components - Tree & Leaf!\n");
            client.ClientCode2(tree, leaf);
        }
    }
}
