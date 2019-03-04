using Dogceo_WebTest.Backend;
using OpenQA.Selenium;

namespace Dogceo_WebTest
{
    static class TestData
    {
        // Use this to manage users details

        #region User1
        public static string User1FirstName = "FName1";
        public static string User1LastName = "LName1";
        public static string User1UserName = "User1";
        public static string User1Password = "Pass1";
        public static By User1Customer = ElementMap.CustomerCompanyAAA;
        public static string User1Role = "Admin";
        public static string User1Email = "admin@mail.com";
        public static int User1MobileNumber = 082555;
        #endregion

        #region User2
        public static string User2FirstName = "FName2";
        public static string User2LastName = "LName2";
        public static string User2UserName = "User2";
        public static string User2Password = "Pass2";
        public static By User2Customer = ElementMap.CustomerCompanyBBB;
        public static string User2Role = "Customer";
        public static string User2Email = "cusomter@mail.com";
        public static int User2MobileNumber = 083444;
        #endregion
    }


}
