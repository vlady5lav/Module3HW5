using System.Collections.Generic;

namespace ModuleHW.CompositePattern
{
    public class Composite : Component
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:Fields should be private", Justification = "<Composite Design Pattern>")]
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in _children)
            {
                result += component.Operation();

                if (i != _children.Count - 1)
                {
                    result += "+";
                }

                i++;
            }

            return result + ")";
        }
    }
}
