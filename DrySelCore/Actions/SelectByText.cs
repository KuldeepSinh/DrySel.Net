using DrySelCore.Actions.Abstractions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DrySelCore.Actions
{
    public class SelectByText : IAction
    {
        public void Fire(IWebDriver webDriver, string xPath, string inputValue)
        {
            IWebElement webElement = webDriver.FindElement(By.XPath(xPath));
            //create select element object
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(inputValue);
        }
    }
}
