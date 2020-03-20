using DrySelCore.Actions.Abstractions;
using OpenQA.Selenium;
using System.Threading;

namespace DrySelCore.Actions
{
    public class SendKeysAndEnter : IAction
    {
        public void Fire(IWebDriver webDriver, string xPath, string inputValue)
        {
            var webElement = webDriver.FindElement(By.XPath(xPath));
            webElement.Clear();
            webElement.SendKeys(inputValue + Keys.Enter);
        }
    }
}
