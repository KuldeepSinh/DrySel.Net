using DrySelCore.Assertions.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace DrySelCore.Assertions
{
    public class AreTextsEqual : IAssertion
    {
        public void Verify(IWebDriver webDriver, string xPath, string expectedValue)
        {
            IWebElement webElement = webDriver.FindElement(By.XPath(xPath));
            Assert.AreEqual(expectedValue, webElement.Text);
        }
    }
}
