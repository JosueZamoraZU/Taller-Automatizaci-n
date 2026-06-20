using Ecommers.PageObject.RegistroPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Practica_1.Test;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace Ecommers.Test.RegistroTest
{
    [TestFixture]
    public class RegistroTest : BaseTest
    {
        public RegistroTest() : base("Registro") 
        { 
        }

        private RegistroPage registroPage;

        [SetUp]
        public void InicializarBrowser()
        {
            // Navegamos a la URL principal del ecommerce
            Driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/");

            registroPage = new RegistroPage(Driver);
        }

        [Test]
        public void RegistrarUsuario_Exitoso()
        {

            // 1. Generamos el número aleatorio y armamos el correo dinámico
            int C_aleatorio = TestContext.CurrentContext.Random.Next(1000, 9999);
            string correoDinamico = $"josue{C_aleatorio}@email.com";

            // Ejecutar el método de negocio en el RegistroPage
            registroPage.RegistrarUsuario(
                "Josue",
                "Zamora",
                correoDinamico,
                "123456789",
                "12345J"
            );

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.UrlContains("route=account/success"));
            Assert.That(Driver.Url, Does.Contain("route=account/success"), "El test no redirigió a la página de éxito.");

            // Aserciones (Validación del resultado esperado)
            // Aquí verificarías si redirigió a la página de éxito o si aparece un mensaje de bienvenida
            IWebElement mensajeExito = Driver.FindElement(By.XPath("//h1[contains(text(),'Your Account Has Been Created!')]"));

            Assert.That(mensajeExito.Displayed, Is.True, "El mensaje de cuenta creada con éxito no se visualiza.");

            Thread.Sleep(2000);
        }
    }
}
