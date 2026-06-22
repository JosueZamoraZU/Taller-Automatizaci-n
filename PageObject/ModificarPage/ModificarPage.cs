using OpenQA.Selenium;
using Practica_1.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.PageObject.ModificarPage
{
    public class ModificarPage : BasePage
    {
        public ModificarPage(IWebDriver driver) : base(driver)
        {
        }
        private By btnMyCuenta = By.XPath(("(//span[@class='title'][normalize-space()='My account'])[2]"));
        private By btnLoginUser = By.XPath(("(//a[@class='list-group-item active'])[1]"));

        private By btnModificar = By.XPath(("(//a[normalize-space()='Edit your account information'])[1]"));

        private By tbxEmail = By.Id("input-email");
        private By tbxContra = By.Id("input-password");

        private By btnLogin = By.XPath("(//input[@value='Login'])[1]");

        private By tbxFirsName = By.Id("input-firstname");
        private By tbxLastName = By.Id("input-lastname");
        private By tbxEmailModif = By.Id("input-email");
        private By tbxPhone = By.Id("input-telephone");

        private By btnContinuar = By.XPath("(//input[@value='Continue'])[1]");
        private By btnBack = By.Id("(//a[normalize-space()='Back'])[1]");

        public void LoginUsuario(string email, string contra)
        {

            Click(btnMyCuenta);
            Click(btnLoginUser);

            IngresarInputs(tbxEmail, email);
            IngresarInputs(tbxContra, contra);

            Click(btnLogin);

        }


        public void ModificarRegistro(string nombre, string apellido, string email, string telefono)
        {
            Click(btnModificar);

            IngresarInputs(tbxFirsName, nombre);
            IngresarInputs(tbxLastName, apellido);
            IngresarInputs(tbxEmailModif, email);
            IngresarInputs(tbxPhone, telefono);

            Click(btnContinuar);
            //Click(btnBack);
        }
    }
}
