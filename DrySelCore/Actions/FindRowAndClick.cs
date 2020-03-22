using DrySelCore.Actions.Abstractions;
using DrySelCore.Shared;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace DrySelCore.Actions
{
    public class FindRowAndClick : IAction
    {
        public void Fire(IWebDriver webDriver, string xPath, string inputValue)
        {
            Fire(webDriver, xPath, new string[] { inputValue });            
        }

        public void Fire(IWebDriver webDriver, string xPath, string[] inputValues)
        {
            IWebElement rowToBeClicked = TableOperations.GetMatchingRow(webDriver, xPath, inputValues);
            if(rowToBeClicked == null)
            {
                throw new NoSuchElementException("Row with given values not found.");
            }
            rowToBeClicked.Click();
        }
    }
}
