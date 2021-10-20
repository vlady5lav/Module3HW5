namespace ModuleHW.BridgePattern
{
    public class Abstraction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:Fields should be private", Justification = "<Bridge Design Pattern>")]
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual string Operation()
        {
            return $"{nameof(Abstraction)}:\nBase operation with " +
                _implementation.OperationImplementation();
        }
    }
}
