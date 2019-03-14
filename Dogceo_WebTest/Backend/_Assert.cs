using System;
using OpenQA.Selenium;

namespace Dogceo_WebTest.Backend
{
    /// <summary>
    /// Used to assert
    /// </summary>
    public  static class _Assert
    {
        /// <summary>
        /// Used to Assert element exists
        /// </summary>
        /// <param name="path">Xpath of element</param>
        /// <returns>bool</returns>
        public  static bool AssertExists(By path)
        {
            try
            {
                // if you dont use try block you get an exception and breaks the test
                Driver.Inst.FindElement(path);
                return true;
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Assert Fail : " + e.Message);
                return false;
            }
        }
    }
}
