using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace Test
{
    public class Excluir : Base
    {
        [Test]
        public void ExcluirCandidato()
        {
            driver.FindElementByLinkText("Candidatos").Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(60))
                .Until(x => x.FindElement(By.CssSelector("td > button.btn-danger")).Displayed);

            driver.FindElementByCssSelector("td > button.btn-danger").Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(60))
                .Until(x => x.FindElement(By.CssSelector("div > button.btn-danger")).Displayed);

            driver.FindElementByCssSelector("div > button.btn-danger").Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(60))
                .Until(x => x.FindElements(By.TagName("p")).Any(y => y.Text == "Candidato excluído."));
        }
    }
}
