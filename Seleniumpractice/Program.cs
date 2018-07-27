using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumpractice
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.yahoo.com");
            PropertiesCollection.driver.Manage().Window.Maximize();
            Console.WriteLine("Opened URL");
        }


        [Test]
        public void ExecuteTest()
        {
            //sign in 
            //driver.FindElement(By.Id("uh-signin")).Click();
            SeleniumSetMethods.DoClick(PropertyType.Id, "uh-signin");
            //email signin 
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.Name("username")).SendKeys("asangeethu@yahoo.com");
            SeleniumSetMethods.SetTextValue(PropertyType.Name, "username", "asangeethu@yahoo.com");
            //driver.FindElement(By.Id("login-signin")).Click();
            SeleniumSetMethods.DoClick(PropertyType.Id, "login-signin");
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //password signin

            //driver.FindElement(By.Id("login-passwd")).SendKeys("@nuk1978");
            SeleniumSetMethods.SetTextValue(PropertyType.Id, "login-passwd", "@nuk1978");
            //driver.FindElement(By.Id("login-signin")).Click();
            SeleniumSetMethods.DoClick(PropertyType.Id, "login-signin");
            Console.WriteLine("Executed Test1");
        }

        
        [TearDown]
        public void CleanUp()
        {
            //driver.Close();

        }
    
    }
}
