using DrySelCore.Model;
using DrySelCore.Script;
using DrySelJSON.Model;
using DrySelJSON.Scripts.Abstractions;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.IO;

namespace DrySelJSON.Scripts
{
    public class JSONTestScriptExecutor : IJSONTestScriptExecutor
    {
        private List<UIElement> UIElementList { get; set; }
        private List<TestData> TestDataList { get; set; }
        private TestScriptExecutor TestScriptExecutor { get; set; }
        private IWebDriver WebDriver { get; set; }
        public JSONTestScriptExecutor(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            TestScriptExecutor = new TestScriptExecutor(WebDriver);
        }

        public void ExecuteInputScript(string uiElementsFilePath, string inputTestDataFilePath)
        {
            //desirialize objects
            DeserializeUIElements(uiElementsFilePath);
            DeserializeTestData(inputTestDataFilePath);
            //execute input script
            ExecuteInputScript();
        }

        public void ExecuteVerificationScript(string uiElementsFilePath, string expectedTestDataFilePath)
        {
            //desirialize objects
            DeserializeUIElements(uiElementsFilePath);
            DeserializeTestData(expectedTestDataFilePath);
            //execute input script
            ExecuteVerificationScript();
        }
        private void DeserializeUIElements(string uiElementsFilePath)
        {
            //deserialize to JsonUIElements
            List<JsonUIElement> jsonUIElementList = JsonConvert.DeserializeObject<List<JsonUIElement>>(File.ReadAllText(uiElementsFilePath));
            //map JsonUIElement to UIElement
            MapJsonUIElementListToUIElementList(jsonUIElementList);
        }

        private void MapJsonUIElementListToUIElementList(List<JsonUIElement> jsonUIElementList)
        {
            UIElementList = new List<UIElement>();
            foreach (JsonUIElement jsonUIElement in jsonUIElementList)
            {
                UIElementList.Add(jsonUIElement.GetUIElement());
            }
        }

        private void DeserializeTestData(string testDataFilePath)
        {
            TestDataList = JsonConvert.DeserializeObject<List<TestData>>(File.ReadAllText(testDataFilePath));
        }
        private void ExecuteInputScript()
        {
            TestScriptExecutor.ExecuteInputScript(UIElementList, TestDataList);
        }

        private void ExecuteVerificationScript()
        {
            TestScriptExecutor.ExecuteVerificationScript(UIElementList, TestDataList);
        }
    }
}
