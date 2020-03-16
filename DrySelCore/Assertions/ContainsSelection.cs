using DrySelCore.Assertions.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace DrySelCore.Assertions
{
    public class ContainsSelection : IAssertion
    {
        public void Verify(IWebDriver webDriver, string xPath, string expectedValue)
        {
            IWebElement webElement = webDriver.FindElement(By.XPath(xPath));
            SelectElement selectElement = new SelectElement(webElement);

            Assert.IsTrue(selectElement.AllSelectedOptions
                .Where(webElement => webElement.Text.Equals(expectedValue))
                .Count() == 1);
        }
    }
}
