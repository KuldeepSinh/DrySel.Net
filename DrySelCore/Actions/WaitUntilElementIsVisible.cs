using DrySelCore.Actions.Abstractions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using WaitHelper = SeleniumExtras.WaitHelpers;
using System.Diagnostics;

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
                try
                {
                    wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(i));
                    var element = wait.Until(WaitHelper.ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
                    if (element != null)
                    {
                        break;
                    }
                }
                catch(WebDriverTimeoutException timeOutException)
                {
                    if(i < 10)
                    {
                        Debug.WriteLine("Attempt number to find " + xPath + " = " + i + ".");
                    }
                    else
                    {
                        throw timeOutException;
                    }
                }
            } while (++i <= 10);
        }
    }
}
