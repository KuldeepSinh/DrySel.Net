using DrySelCore.Actions.Abstractions;
using OpenQA.Selenium;
using System.Threading;

namespace DrySelCore.Actions
{
    public class WaitForMilliSeconds : IAction
    {
        public void Fire(IWebDriver webDriver, string xPath, string inputValue)
        {
            Thread.Sleep(int.Parse(inputValue));
        }
    }
}
