using DrySelCore.Assertions.Abstractions;

namespace DrySelCore.Model
{
    public class VerificationStep
    {
        public string ElementId { get; set; }
        public IAssertion Assertion { get; set; }
        public string ExpectedData { get; set; }
        public string[] ExpectedDataArray { get; set; }

    }
}
