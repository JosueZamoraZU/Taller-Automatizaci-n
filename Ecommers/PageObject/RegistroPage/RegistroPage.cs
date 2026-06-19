using OpenQA.Selenium;
using Practica_1.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.PageObject.RegistroPage
{
    public class RegistroPage : BasePage
    {
        public RegistroPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string registroUrl = "https://ecommerce-playground.lambdatest.io/";

        private By tbxFirsName = By.Id("firstname");
        private By tbxLastName = By.Id("lastname");
        private By tbxEmail = By.Id("input-email");
        private By tbxPhone = By.Id("input-telephone");


    }
}
