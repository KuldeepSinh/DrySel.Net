using OpenQA.Selenium;

namespace DrySelCore.Assertions.Abstractions
{
    public interface IAssertion
    {
        void Verify(IWebDriver webDriver, string xPath, string expectedValue);
        void Verify(IWebDriver webDriver, string xPath, string[] expectedValues)
        {
            throw new System.NotImplementedException();
        }
    }
}
