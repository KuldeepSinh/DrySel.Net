using DrySelCore.Model;
using DrySelCore.Scripts.Abstractions;
using System.Collections.Generic;

namespace DrySelCore.Scripts
{
    public class InputScript : IInputScript
    {
        public SortedDictionary<int, InputStep> Script { get; set; }

        public InputScript()
        {
            Script = new SortedDictionary<int, InputStep>();
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
                    }
                }
            }

        }

        private void AddStepToScript(UIElement uiElement, TestData testData)
        {
            Script.Add(testData.StepNumber,
                new InputStep
                {
                    ElementId = uiElement.ElementID,
                    Action = uiElement.InputAction,
                    InputData = testData.Value,
                    InputDataArray = testData.ValueArray
                });
        }
    }
}
