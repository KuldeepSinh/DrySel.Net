using DrySelCore.Actions.Abstractions;
using OpenQA.Selenium;

namespace DrySelCore.Actions
{
    public class SendKeys : IAction
    {
        public void Fire(IWebDriver webDriver, string xPath, string inputValue)
        {
            var webElement = webDriver.FindElement(By.XPath(xPath));
            webElement.Clear();
            webElement.SendKeys(inputValue);
        }
    }
}
