using OpenQA.Selenium;
using Practica_1.PageObject;

namespace Ecommers.PageObject.RegistroPage
{
    public class RegistroPage : BasePage
    {
        public RegistroPage(IWebDriver driver) : base(driver)
        {
        }

        private By btnMyCuenta = By.XPath(("(//span[@class='title'][normalize-space()='My account'])[2]"));
        private By btnRegistro = By.XPath(("(//a[contains(text(),'Register')])[1]"));
        private By tbxFirsName = By.Id("input-firstname");
        private By tbxLastName = By.Id("input-lastname");
        private By tbxEmail = By.Id("input-email");
        private By tbxPhone = By.Id("input-telephone");
        private By tbxContra = By.Id("input-password");
        private By tbxConContra = By.Id("input-confirm");
        //private By rbSubcribe = By.Id("input-newsletter-no");
        private By chkPrivacidad = By.XPath("(//label[@for='input-agree'])[1]");
        private By btnContinuar = By.XPath("(//input[@value='Continue'])[1]");

        public void RegistrarUsuario(string nombre, string apellido, string email, string telefono, string contra)
        {
            Click(btnMyCuenta);
            Click(btnRegistro);

            IngresarInputs(tbxFirsName, nombre);
            IngresarInputs(tbxLastName, apellido);
            IngresarInputs(tbxEmail, email);
            IngresarInputs(tbxPhone, telefono);
            IngresarInputs(tbxContra, contra);
            IngresarInputs(tbxConContra, contra);
            Click(chkPrivacidad);
            Click(btnContinuar);

        }



    }
}
