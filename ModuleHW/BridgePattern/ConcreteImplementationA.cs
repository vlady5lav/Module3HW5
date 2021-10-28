namespace ModuleHW.BridgePattern
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return $"{nameof(ConcreteImplementationA)}.\nThe result in platform A.\n";
        }
    }
}
