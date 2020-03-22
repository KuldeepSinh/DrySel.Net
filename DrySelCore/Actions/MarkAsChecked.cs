using DrySelCore.Actions.Abstractions;
using OpenQA.Selenium;

namespace DrySelCore.Actions
{
    public class MarkAsChecked : IAction
    {
        public void Fire(IWebDriver webDriver, string xPath, string inputValue)
        {
            IWebElement webElement = webDriver.FindElement(By.XPath(xPath));
            ClickIfEnabled(webElement);
        }

        private void ClickIfEnabled(IWebElement webElement)
        {
            if (webElement.Enabled && !webElement.Selected)
            {
                webElement.Click();
            }
        }

    }
}
