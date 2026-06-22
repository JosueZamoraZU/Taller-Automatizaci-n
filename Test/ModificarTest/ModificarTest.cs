using Ecommers.PageObject.LoginPage;
using Ecommers.PageObject.ModificarPage;
using OpenQA.Selenium.Support.UI;
using Practica_1.Test;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ecommers.Test.ModificarTest
{
    public class ModificarTest : BaseTest
    {

        private string nombre = "Josue David";
        private string apellido = "Zamora Zuñiga";
        private string modifEmail = "JosueDavid@email.com";
        private string telefono = "12345678910";

        public ModificarTest() : base("Modificar")
        {
        }

        private ModificarPage modif;

        [SetUp]

        public void InicializarBrowser()
        {
            // Navegamos a la URL principal del ecommerce
            Driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/");

            modif = new ModificarPage(Driver);
        }

        [Test]

        public void ModificarUsuario()
        {
            // Inicializar el Setup
            modif.LoginUsuario("josue@email.com", "12345J");

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.UrlContains("route=account/account"));

            // Verificar que entraste a la cuenta
            Assert.That(Driver.Url, Does.Contain("route=account"), "No se logró iniciar sesión.");

            Thread.Sleep(1000);

            //Modificar registros
            modif.ModificarRegistro(nombre, apellido, modifEmail, telefono);

            wait.Until(ExpectedConditions.UrlContains("route=account/account"));

            var mensajeExito = Driver.FindElement(OpenQA.Selenium.By.XPath("//div[contains(@class, 'alert-success')]"));
            Assert.That(mensajeExito.Text, Does.Contain("Success: Your account has been successfully updated."));

            Thread.Sleep(1000);
        }
    }
}
