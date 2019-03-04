using Dogceo_WebTest.Backend;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Dogceo_WebTest
{
    public static class Operations
    {
        /// <summary>
        /// Used to Add a User
        /// </summary>
        /// <param name="FirstName">First Name</param>
        /// <param name="LastName">Last Name</param>
        /// <param name="UserName">UserName</param>
        /// <param name="Password">Password</param>
        /// <param name="Customer">Customer</param>
        /// <param name="Role">Role</param>
        /// <param name="Email">Email</param>
        /// <param name="MobileNumber">MobileNumber</param>
        /// <param name="Verify">to assert user exists after save</param>
        public static void AddUser(string FirstName, string LastName, string UserName, string Password, By Customer, string Role, string Email, int MobileNumber, bool Verify)
        {
            // Check user does not exist
            Assert.IsFalse(_Assert.AssertExists(By.XPath("//td[contains(.,'" + UserName + "')]")));

            // Click Add User Button
            Driver.Inst.FindElement(ElementMap.AddUserButton).Click();

            // Type First name
            SendText(ElementMap.FirstName, FirstName);

            // Type Last name
            SendText(ElementMap.LastName, LastName);

            // Type User Name
            SendText(ElementMap.UserName, UserName);

            // Type Password
            SendText(ElementMap.Password, Password);

            // Click Customer 
            Driver.Inst.FindElement(Customer).Click();

            // Select Role "Admin"
            SelectElement role = new SelectElement(Driver.Inst.FindElement(ElementMap.Role));
            role.SelectByText(Role);

            // Type Email address
            SendText(ElementMap.Email, Email);

            // Type Email address
            SendText(ElementMap.Mobilephone, MobileNumber.ToString());

            //Save User
            Driver.Inst.FindElement(ElementMap.Save).Click();

            if (Verify)
            {
                VerifyText(FirstName);
                VerifyText(LastName);
                VerifyText(UserName);
                VerifyText(Role);
                VerifyText(Email);
                VerifyText(MobileNumber.ToString());
            }
        }

        /// <summary>
        /// Used to clear input before sending text
        /// </summary>
        /// <param name="Element">to send text to</param>
        /// <param name="text">text to send</param>
        private static void SendText(By Element, string text)
        {
            Driver.Inst.FindElement(Element).Clear();
            Driver.Inst.FindElement(Element).SendKeys(text);
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
