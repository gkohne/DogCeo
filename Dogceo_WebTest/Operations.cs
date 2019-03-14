using Dogceo_WebTest.Backend;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Dogceo_WebTest
{
    /// <summary>
    /// Shared operations for test
    /// </summary>
    public static class Operations
    {
        /// <summary>
        /// Used to Add a User
        /// </summary>
        /// <param name="firstName">First Name</param>
        /// <param name="lastName">Last Name</param>
        /// <param name="name">UserName</param>
        /// <param name="password">Password</param>
        /// <param name="customer">Customer</param>
        /// <param name="role">Role</param>
        /// <param name="email">Email</param>
        /// <param name="mobileNumber">MobileNumber</param>
        /// <param name="verify">to assert user exists after save</param>
        public static void AddUser(string firstName, string lastName, string name, string password, By customer, string role, string email, int mobileNumber, bool verify)
        {
            // Check user does not exist
            Assert.IsFalse(_Assert.AssertExists(By.XPath("//td[contains(.,'" + name + "')]")));

            // Click Add User Button
            Driver.Inst.FindElement(ElementMap.AddUserButton).Click();

            // Type First name
            SendText(ElementMap.FirstName, firstName);

            // Type Last name
            SendText(ElementMap.LastName, lastName);

            // Type User Name
            SendText(ElementMap.Name, name);

            // Type Password
            SendText(ElementMap.Password, password);

            // Click Customer 
            Driver.Inst.FindElement(customer).Click();

            // Select Role "Admin"
            SelectElement therole = new SelectElement(Driver.Inst.FindElement(ElementMap.Role));
            therole.SelectByText(role);

            // Type Email address
            SendText(ElementMap.Email, email);

            // Type Email address
            SendText(ElementMap.Mobilephone, mobileNumber.ToString());

            //Save User
            Driver.Inst.FindElement(ElementMap.Save).Click();

            if (verify)
            {
                VerifyText(firstName);
                VerifyText(lastName);
                VerifyText(name);
                VerifyText(role);
                VerifyText(email);
                VerifyText(mobileNumber.ToString());
            }
        }

        /// <summary>
        /// Used to clear input before sending text
        /// </summary>
        /// <param name="element">to send text to</param>
        /// <param name="text">text to send</param>
        private static void SendText(By element, string text)
        {
            Driver.Inst.FindElement(element).Clear();
            Driver.Inst.FindElement(element).SendKeys(text);
        }

        /// <summary>
        /// Used to assert text
        /// </summary>
        /// <param name="text">text to verify</param>
        private static void VerifyText(string text)
        {
            Assert.AreEqual(text, Driver.Inst.FindElement(By.XPath("//td[contains(.,'" + text + "')]")).Text);
        }
    }
}
