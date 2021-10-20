using System;

namespace ModuleHW.BridgePattern
{
    public class Client
    {
        public void ClientCode(Abstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }
}
