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

        public static void SetTextValue(PropertyType SearchBy, string SearchValue, string Text)
        {
            if (SearchBy == PropertyType.Name)
            {
                PropertiesCollection.driver.FindElement(By.Name(SearchValue)).SendKeys(Text);
            }
            else
            {
                PropertiesCollection.driver.FindElement(By.Id(SearchValue)).SendKeys(Text);
            }
        }

        public static void DoClick (PropertyType SearchBy, string SearchValue)
        {
            if(SearchBy == PropertyType.Id)
            {
                PropertiesCollection.driver.FindElement(By.Id(SearchValue)).Click();
            }
            else
            {
                PropertiesCollection.driver.FindElement(By.Name(SearchValue)).Click();
            }
        }
    }
}
