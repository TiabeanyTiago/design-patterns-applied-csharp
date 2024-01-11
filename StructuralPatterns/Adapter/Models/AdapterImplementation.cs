using DesignPatternsApp.StructuralPatterns.Adapter.Interfaces;

namespace DesignPatternsApp.StructuralPatterns.Adapter.Models
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class AdapterImplementation : ITarget
    {
        private readonly Adaptee _adaptee;

        public AdapterImplementation(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }
    }
}
