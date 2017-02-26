using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace Test
{
    public class Alterar : Base
    {
        [Test]
        public void AlterarCandidato()
        {
            driver.FindElementByLinkText("Candidatos").Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(60))
                .Until(x => x.FindElement(By.LinkText("Editar")).Displayed);

            driver.FindElementByLinkText("Editar").Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(60))
                .Until(x => x.FindElements(By.ClassName("btn-primary")).Any(y => y.Displayed && y.Text == "Próxima"));

            driver.FindElementsByCssSelector("div > input").ToList().ForEach(x => 
            {
                var text = new string(x.GetAttribute("value").Reverse().ToArray());
                x.Clear();
                x.SendKeys(text);
            });
            driver.FindElementsByName("grupo-horas").ToList().ForEach(x => x.Click());
            driver.FindElementsByName("grupo-periodo").ToList().ForEach(x => x.Click());
            driver.FindElementsByClassName("btn-primary").FirstOrDefault(x => x.Text == "Próxima").Click();

            driver.FindElementsByCssSelector("div > input").ToList().ForEach(x =>
            {
                var text = new string(x.GetAttribute("value").Reverse().ToArray());
                x.Clear();
                x.SendKeys(text);
            });
            driver.FindElementsByCssSelector("label > input").ToList().ForEach(x => x.Click());
            driver.FindElementsByClassName("btn-primary").FirstOrDefault(x => x.Text == "Próxima").Click();
            
            new WebDriverWait(driver, TimeSpan.FromSeconds(60))
                .Until(x => x.FindElement(By.ClassName("btn-success")).Displayed);
            driver.FindElementsByName("radioionic")[new Random().Next(6)].Click();
            driver.FindElementsByName("radioandroid")[new Random().Next(6)].Click();
            driver.FindElementsByName("radioios")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiohtml")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiocss")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiobootstrap")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiojquery")[new Random().Next(6)].Click();
            driver.FindElementsByName("radioangular")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiojava")[new Random().Next(6)].Click();
            driver.FindElementsByName("radioasp")[new Random().Next(6)].Click();
            driver.FindElementsByName("radioc")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiocplusplus")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiocake")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiodjango")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiomajento")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiophp")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiowordpress")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiopython")[new Random().Next(6)].Click();
            driver.FindElementsByName("radioruby")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiosqlServer")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiomySql")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiosalesforce")[new Random().Next(6)].Click();
            driver.FindElementsByName("radiophotoshop")[new Random().Next(6)].Click();
            driver.FindElementsByName("radioillustrator")[new Random().Next(6)].Click();
            driver.FindElementsByName("radioseo")[new Random().Next(6)].Click();
            driver.FindElementsByCssSelector("div > input").ToList().ForEach(x =>
            {
                var text = new string(x.GetAttribute("value").Reverse().ToArray());
                x.Clear();
                x.SendKeys(text);
            });
            driver.FindElementByClassName("btn-success").Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(60))
                .Until(x => x.FindElements(By.TagName("p")).Any(y => y.Text == "Cadastro atualizado."));
        }
    }
}
