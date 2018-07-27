using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumpractice
{
    class PropertiesCollection
    {
        //create reference for the browser and set it as a global variable
        public static IWebDriver driver = new ChromeDriver();
    }
}
