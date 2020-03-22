using DrySelCore.Shared;
using DrySelCore.Assertions.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace DrySelCore.Assertions
{
    public class ThereExistsARowInTheTable : IAssertion
    {
        public void Verify(IWebDriver webDriver, string xPath, string expectedValue)
        {
            Verify(webDriver, xPath, new string[] { expectedValue });
        }

        public void Verify(IWebDriver webDriver, string xPath, string[] expectedValues)
        {
            Assert.IsNotNull(TableOperations.GetMatchingRow(webDriver, xPath, expectedValues));
        }
    }
}
