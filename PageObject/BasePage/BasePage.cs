using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Practica_1.PageObject
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;
        protected WebDriverWait wait;

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        //protected IWebElement WaitForElement(By locator)
        //{
        //    //return Driver.FindElement(locator);
        //    return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        //}

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }

        // Método para navegar a una URL
        protected void NavegarA(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        // Método para encontrar un elemento esperando a que sea visible
        protected IWebElement EncontrarElemento(By localizador)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(localizador));
        }

        // Método para escribir texto en un input
        protected void IngresarInputs(By localizador, string texto)
        {
            IWebElement elemento = EncontrarElemento(localizador);
            elemento.Clear();
            elemento.SendKeys(texto);
        }

        // Método para hacer clic en un elemento
        protected void Click(By localizador)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(localizador)).Click();
        }

        //protected string ObtenerTexto(string texto)
        //{

        //}
    }
}
