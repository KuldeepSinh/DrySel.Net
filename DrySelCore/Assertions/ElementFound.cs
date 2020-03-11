using DrySelCore.Assertions.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace DrySelCore.Assertions
{
    public class ElementFound : IAssertion
    {
        public void Verify(IWebDriver webDriver, string xPath, string expectedValue)
        {
            try
            {
                IWebElement webElement = webDriver.FindElement(By.XPath(xPath));
                if (!bool.Parse(expectedValue))
                {
                    Assert.Fail("The unexpected element: " + xPath + " is found, while it should not be.");
                }
            }
            catch(NoSuchElementException)
            {
                if (bool.Parse(expectedValue))
                {
                    Assert.Fail("The expected element: " + xPath + " is not found, while it should be.");
                }
            }
        }
    }
}
