using DrySelCore.Model;
using DrySelCore.Scripts.Abstractions;
using System.Collections.Generic;

namespace DrySelCore.Scripts
{
    public class VerificationScript : IVerificationScript
    {
        public SortedDictionary<int, VerificationStep> Script { get; set; }

        public VerificationScript()
        {
            Script = new SortedDictionary<int, VerificationStep>();
        }

        public void PrepareScript(IEnumerable<UIElement> uiElementList, IEnumerable<TestData> testDataList)
        {
            foreach (TestData testData in testDataList)
            {
                foreach (UIElement uiElement in uiElementList)
                {
                    if (testData.Key.Equals(uiElement.Key))
                    {
                        AddStepToScript(uiElement, testData);
                        break;
                    }
                }
            }

        }

        private void AddStepToScript(UIElement uiElement, TestData testData)
        {
            Script.Add(testData.StepNumber, new VerificationStep { ElementId = uiElement.ElementID, Assertion = uiElement.Assertion, ExpectedData = testData.Value });
        }
    }
}
