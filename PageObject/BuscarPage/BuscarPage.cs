using OpenQA.Selenium;
using Practica_1.PageObject;

namespace Ecommers.PageObject.BuscarPage
{
    public class BuscarPage : BasePage
    {
        public BuscarPage(IWebDriver driver) : base(driver)
        {
        }

        private By tbxSearch = By.XPath("(//input[@placeholder='Search For Products'])[1]");

        private By btnBuscar = By.XPath("(//button[normalize-space()='Search'])[1]");

        public void BuscarProducto(string producto)
        {
            Click(tbxSearch);
            IngresarInputs(tbxSearch, producto);

            Click(btnBuscar);
        }
    }
}
