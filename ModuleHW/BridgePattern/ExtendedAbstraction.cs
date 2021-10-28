namespace ModuleHW.BridgePattern
{
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation)
            : base(implementation)
        {
        }

        public override string Operation()
        {
            return $"{nameof(ExtendedAbstraction)}:\nExtended operation with " +
                _implementation.OperationImplementation();
        }
    }
}
