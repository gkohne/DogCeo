using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dogceo_WebTest.Backend
{
    // Sets up the Web Driver
    public  static class Driver
    {
        private static IWebDriver _uniqueInstance;

        /// <summary>
        /// Make instance to be reused
        /// </summary>
        public static IWebDriver Inst
        {
            get
            {
                if (_uniqueInstance == null)
                {
                    // Use chrome driver located in Webdriver folder
                    _uniqueInstance = new ChromeDriver(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()))) + @"\Dogceo_WebTest\Backend\WebDriver\");
                }

                return _uniqueInstance;
            }
        }

    }
}
