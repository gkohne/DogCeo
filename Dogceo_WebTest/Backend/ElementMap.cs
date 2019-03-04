using OpenQA.Selenium;

namespace Dogceo_WebTest.Backend
{
    public  static class ElementMap
    {
        // This allows for easy update for if the name attribue changes
        public  static By UserTableList { get { return By.CssSelector(".smart-table-header-cell:nth-child(1) > .header-content"); } }
        public  static By AddUserButton { get { return By.XPath("/html/body/table/thead/tr[2]/td/button"); } }
        public  static By FirstName {  get { return By.XPath("//input[@name='FirstName']"); } }
        public  static By LastName { get { return By.XPath("//input[@name='LastName']"); } }
        public  static By UserName { get { return By.XPath("//input[@name='UserName']"); } }
        public  static By Password { get { return By.XPath("//input[@name='Password']"); } }
        public  static By CustomerCompanyAAA {  get { return By.XPath("//label[contains(.,'Company AAA')]"); } }
        public  static By CustomerCompanyBBB { get { return By.XPath("//label[contains(.,'Company BBB')]"); } }
        public  static By Role { get { return By.XPath("/html/body/div[3]/div[2]/form/table/tbody/tr[6]/td[2]/select"); } }
        public  static By Email { get { return By.XPath("//input[@name='Email']"); } }
        public  static By Mobilephone { get { return By.XPath("//input[@name='Mobilephone']"); } }
        public  static By Save {  get { return By.XPath("//button[contains(.,'Save')]"); } }

    }
}
