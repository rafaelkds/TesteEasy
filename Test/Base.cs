using System;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Test
{
    public class Base
    {
        protected ChromeDriver driver;

        public Base()
        {
            driver = new ChromeDriver();
        }

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl("http://localhost:57250");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(x => x.FindElement(By.Id("mensagem-modal")));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
