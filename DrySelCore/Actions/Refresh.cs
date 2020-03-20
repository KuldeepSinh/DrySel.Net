using DrySelCore.Actions.Abstractions;
using OpenQA.Selenium;

namespace DrySelCore.Actions
{
    public class Refresh : IAction
    {
        public void Fire(IWebDriver webDriver, string xPath, string inputValue)
        {
            webDriver.Navigate().Refresh();
        }
    }
}
