using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumpractice
{
    class SeleniumSetMethods
    {

        public static void SetTextValue(string SearchBy, string SearchValue, string Text)
        {
            if (SearchBy == "name")
            {
                PropertiesCollection.driver.FindElement(By.Name(SearchValue)).SendKeys(Text);
            }
            else
            {
                PropertiesCollection.driver.FindElement(By.Id(SearchValue)).SendKeys(Text);
            }
        }

        public static void DoClick (string SearchBy, string SearchValue)
        {
            if(SearchBy == "name")
            {
                PropertiesCollection.driver.FindElement(By.Name(SearchValue)).Click();
            }
            else
            {
                PropertiesCollection.driver.FindElement(By.Id(SearchValue)).Click();
            }
        }
    }
}
