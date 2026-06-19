using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Genericos.DriverConfig
{
    public class ChromeFactory
    {


        public static IWebDriver CrearDriver(ChromeOptions options)
        {
            return new ChromeDriver(options);
        }
    }
}
