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

        protected IWebElement WaitForElement(By locator)
        {
            //return Driver.FindElement(locator);
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }
    }
}
