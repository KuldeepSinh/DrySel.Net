using DrySelCore.Actions.Abstractions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;

namespace DrySelCore.Actions
{
    public class WaitUntilElementIsVisible : IAction
    {
        private WebDriverWait wait;
        public void Fire(IWebDriver webDriver, string xPath, string inputValue)
        {
            int i = 1;
            do
            {
                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(i));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(inputValue)));
                if (element != null)
                {
                    break;
                }
            } while (++i <= 10);
        }
    }
}
