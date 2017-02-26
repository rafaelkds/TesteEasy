using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace Test
{
    public class Cadastrar : Base
    {
        [Test]
        public void CadastrarCandidato()
        {
            driver.FindElementById("email").SendKeys("joao@gmail.com");
            driver.FindElementById("nome").SendKeys("João Silva");
            driver.FindElementById("skype").SendKeys("joaosilva");
            driver.FindElementById("whatsapp").SendKeys("987654321");
            driver.FindElementById("linkedin").SendKeys("linkedin.com/joaosilva");
            driver.FindElementById("cidade").SendKeys("São Paulo");
            driver.FindElementById("estado").SendKeys("SP");
            driver.FindElementById("portfolio").SendKeys("joaosilva.com");
            driver.FindElementsByName("grupo-horas")[3].Click();
            driver.FindElementsByName("grupo-periodo")[4].Click();
            driver.FindElementById("pretensao").SendKeys("30");
            driver.FindElementById("banco").SendKeys("Conta corrente");
            driver.FindElementsByClassName("btn-primary").FirstOrDefault(x => x.Text == "Próxima").Click();

            driver.FindElementById("bancoBeneficiario").SendKeys("João Silva");
            driver.FindElementById("bancoCpf").SendKeys("98765432100");
            driver.FindElementById("bancoNome").SendKeys("Banco do Brasil");
            driver.FindElementById("bancoAgencia").SendKeys("1234-5");
            driver.FindElementsByTagName("label").FirstOrDefault(x => x.Text == "Chain / Corrente").Click();
            driver.FindElementById("bancoConta").SendKeys("5432-1");
            driver.FindElementsByClassName("btn-primary").FirstOrDefault(x => x.Text == "Próxima").Click();

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
            driver.FindElementById("conhecimentoOutros").SendKeys("Assembly - 5");
            driver.FindElementById("linkCrud").SendKeys("github.com/joao/teste");
            driver.FindElementByClassName("btn-success").Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(60))
                .Until(x => x.FindElements(By.TagName("p")).Any(y => y.Text == "Cadastro enviado."));
        }
    }
}
