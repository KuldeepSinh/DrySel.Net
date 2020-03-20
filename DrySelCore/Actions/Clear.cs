using DrySelCore.Actions.Abstractions;
using OpenQA.Selenium;
using System.Threading;

namespace DrySelCore.Actions
{
    public class Clear : IAction
    {
        public void Fire(IWebDriver webDriver, string xPath, string inputValue)
        {
            IWebElement webElement = webDriver.FindElement(By.XPath(xPath));
            Thread.Sleep(500);
            webElement.Clear();
            for(int i = 0; i < 10; i++)
            {
                webElement.SendKeys(Keys.Backspace);
            }
            Thread.Sleep(500);
        }

    }
}
