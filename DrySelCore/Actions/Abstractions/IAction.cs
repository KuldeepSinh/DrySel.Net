using OpenQA.Selenium;

namespace DrySelCore.Actions.Abstractions
{
    public interface IAction
    {
        void Fire(IWebDriver webDriver, string xPath, string inputValue);
        void Fire(IWebDriver webDriver, string xPath, string[] inputValues)
        {
            throw new System.NotImplementedException();
        }
    }
}
