using DrySelCore.Actions.Abstractions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace DrySelCore.Actions
{
    public class FindCellAndClick : IAction
    {
        public void Fire(IWebDriver webDriver, string xPath, string inputValue)
        {
            var columns = webDriver.FindElements(By.XPath(xPath + "//tr//td"));
            var column = columns.Where(column => column.Text.Equals(inputValue)).FirstOrDefault();
            column.Click();
        }
    }
}
