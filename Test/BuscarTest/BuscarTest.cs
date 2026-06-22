using Ecommers.PageObject.BuscarPage;
using OpenQA.Selenium.Support.UI;
using Practica_1.Test;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace Ecommers.Test.BuscarTest
{
    [TestFixture]
    public class BuscarTest : BaseTest
    {

        private string producto1 = "iPhone";
        private string producto2 = "iPod";
        public BuscarTest() : base("Buscar")
        {   
        }

        private BuscarPage search;

        [SetUp]

        public void InicializarBrowser()
        {
            // Navegamos a la URL principal del ecommerce
            Driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/");

            search = new BuscarPage(Driver);
        }

        [Test]

        public void Buscar() { 
            
            search.BuscarProducto(producto1);

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.UrlContains("route=product%2Fsearch&search=iPhone"));

            // Verificar que entraste a la cuenta
            Assert.That(Driver.Url, Does.Contain("route=product%2Fsearch&search=iPhone"), "No se logró iniciar sesión.");

            Thread.Sleep(1000);
        }
    }
}
