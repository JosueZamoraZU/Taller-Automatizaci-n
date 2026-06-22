using OpenQA.Selenium;
using Practica_1.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.PageObject.LoginPage
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private By btnMyCuenta = By.XPath(("(//span[@class='title'][normalize-space()='My account'])[2]"));
        private By btnLoginUser = By.XPath(("(//a[@class='list-group-item active'])[1]"));

        private By tbxEmail = By.Id("input-email");
        private By tbxContra = By.Id("input-password");

        private By btnLogin = By.XPath("(//input[@value='Login'])[1]");


        public void LoginUsuario(string email, string contra){

            Click(btnMyCuenta);
            Click(btnLoginUser);

            IngresarInputs(tbxEmail, email);
            IngresarInputs(tbxContra, contra);

            Click(btnLogin);

        }
    }
}
