using DrySelCore.Model;
using DrySelCore.Scripts.Abstractions;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace DrySelCore.Script.Abstractions
{
    public interface ITestScriptExecutor
    {
        IInputScript InputScript { get; set; }
        IVerificationScript VerificationScript { get; set; }
        IWebDriver WebDriver { get; set; }

        void ExecuteInputScript(IEnumerable<UIElement> uiElementList, IEnumerable<TestData> testDataList);
        void ExecuteVerificationScript(IEnumerable<UIElement> uiElementList, IEnumerable<TestData> testDataList);
    }
}