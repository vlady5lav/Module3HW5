namespace ModuleHW.BridgePattern
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return $"{nameof(ConcreteImplementationB)}.\nThe result in platform B.\n";
        }
    }
}
