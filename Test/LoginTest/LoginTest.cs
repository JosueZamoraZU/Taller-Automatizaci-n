using Ecommers.PageObject.LoginPage;
using Ecommers.PageObject.RegistroPage;
using OpenQA.Selenium.Support.UI;
using Practica_1.Test;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ecommers.Test.LoginTest
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        public LoginTest() : base("Login")
        {
        }

        private LoginPage login;

        [SetUp]

        public void InicializarBrowser()
        {
            // Navegamos a la URL principal del ecommerce
            Driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/");

            login = new LoginPage(Driver);
        }

        [Test]

        public void Login() {

            // Usas la variable que inicializaste en el Setup para ejecutar la acción
            login.LoginUsuario("josue@email.com", "12345J");

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.UrlContains("route=account/account"));

            // Tu assert para verificar que entraste a la cuenta
            Assert.That(Driver.Url, Does.Contain("route=account"), "No se logró iniciar sesión.");

            Thread.Sleep(1000);
        }
    }
}
