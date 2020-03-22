using DrySelCore.Actions.Abstractions;
using DrySelCore.Shared;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace DrySelCore.Actions
{
    public class FindCellElementAndClick : IAction
    {
        public void Fire(IWebDriver webDriver, string xPath, string inputValue)
        {
            throw new System.NotImplementedException("Call other varient of this method, where third argument is an arrya of stirngs.");
        }

        public void Fire(IWebDriver webDriver, string xPathOfTheTable, string[] inputValues)
        {
            //find row
            IWebElement rowContainingTheElement = 
                TableOperations.GetMatchingRow(webDriver, xPathOfTheTable, inputValues.Take(inputValues.Length - 1).ToArray());
            if (rowContainingTheElement == null)
            {
                throw new NoSuchElementException("Not able to find matching row.");
            }
            //find element
            IWebElement elementToBeClicked = rowContainingTheElement.FindElement(By.XPath("." + inputValues.Last()));
            //click
            elementToBeClicked.Click();
        }
    }
}
