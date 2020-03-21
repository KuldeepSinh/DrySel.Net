using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DrySelCore.Actions.Shared
{
    public static class TableOperations
    {
        public static IWebElement GetMatchingRow(IWebDriver webDriver, string xPathOfTable, string[] inputValues)
        {
            var rows = webDriver.FindElements(By.XPath(xPathOfTable + "//tr"));
            IWebElement matchingRow = null;
            for(int i = rows.Count - 1; i >=0; i-- )
            {
                if(CheckIfCellsAreMatching(rows[i].FindElements(By.TagName("td")), inputValues))
                {
                    matchingRow = rows[i];
                    break;
                }

            }
            return matchingRow;
        }

        private static bool CheckIfCellsAreMatching(ReadOnlyCollection<IWebElement> columns, string[] values)
        {
            bool matchFound = false;
            for(int i = 0; i < columns.Count(); i++)
            {
                if (columns[i].Text.Equals(values[i]))
                {
                    matchFound = true;
                    continue;
                }
                else
                {
                    matchFound = false;
                    break;
                }
            }
            return matchFound;
        }
    }
}
