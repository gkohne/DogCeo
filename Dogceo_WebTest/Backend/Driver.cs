using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace Dogceo_WebTest.Backend
{
    public  static class Driver
    {
        private static IWebDriver _unique_instance;

        /// <summary>
        /// Make instance to be reused
        /// </summary>
        public static IWebDriver Inst
        {
            get
            {
                if (_unique_instance == null)
                {
                    // Use chrome driver located in Webdriver folder
                    _unique_instance = new ChromeDriver(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()))) + @"\Dogceo_WebTest\Backend\WebDriver\");
                }

                return _unique_instance;
            }
        }

    }
}
