using DrySelCore.Assertions.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace DrySelCore.Assertions
{
    public class IsSelected : IAssertion
    {
        public void Verify(IWebDriver webDriver, string xPath, string expectedValue)
        {
            IWebElement webElement = webDriver.FindElement(By.XPath(xPath));
            Assert.AreEqual(bool.Parse(expectedValue), webElement.Selected);
        }
    }
}
