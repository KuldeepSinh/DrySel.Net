using DrySelCore.Model;
using DrySelCore.Script.Abstractions;
using DrySelCore.Scripts;
using DrySelCore.Scripts.Abstractions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace DrySelCore.Script
{
    public class TestScriptExecutor : ITestScriptExecutor
    {
        public IWebDriver WebDriver { get; set; }
        public IInputScript InputScript { get; set; }
        public IVerificationScript VerificationScript { get; set; }

        public TestScriptExecutor(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            InputScript = new InputScript();
            VerificationScript = new VerificationScript();
        }

        public void ExecuteInputScript(IEnumerable<UIElement> uiElementList, IEnumerable<TestData> testDataList)
        {
            InputScript.PrepareScript(uiElementList, testDataList);
            ExecuteScript(InputScript.Script);
        }
        public void ExecuteVerificationScript(IEnumerable<UIElement> uiElementList, IEnumerable<TestData> testDataList)
        {
            VerificationScript.PrepareScript(uiElementList, testDataList);
            ExecuteScript(VerificationScript.Script);
        }

        private void ExecuteScript(SortedDictionary<int, InputStep> script)
        {
            foreach (KeyValuePair<int, InputStep> entry in script)
            {
                ExecuteInputStep(entry.Value);
            }
        }

        private void ExecuteScript(SortedDictionary<int, VerificationStep> script)
        {
            foreach (KeyValuePair<int, VerificationStep> entry in script)
            {
                ExecuteVerificationStep(entry.Value);
            }
        }

        private void ExecuteVerificationStep(VerificationStep step)
        {
            if (step.Assertion != null)
            {
                Console.WriteLine($"UI Element = {step.ElementId}, Expected Data = {step.ExpectedData}, Assertion = { step.Assertion.ToString()}.");
                step.Assertion.Verify(WebDriver, step.ElementId, step.ExpectedData);
            }
        }

        private void ExecuteInputStep(InputStep step)
        {
            if (step.Action != null)
            {
                Console.WriteLine($"UI Element = {step.ElementId}, Input Data = {step.InputData}, Input Action = { step.Action.ToString()}.");
                step.Action.Fire(WebDriver, step.ElementId, step.InputData);
            }
        }
    }
}
