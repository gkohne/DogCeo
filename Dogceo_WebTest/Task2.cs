using Dogceo_WebTest.Backend;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Dogceo_WebTest.Backend.Navigate;

namespace Dogceo_WebTest
{
    [CodedUITest]
    public class Task2
    {
        [TestMethod]
        public void Webtest()
        {
            // Navigate to Landing page
            NavigateTo(Page.HomePage);

            // Assert on User List Table
            Assert.IsTrue(_Assert.AssertExists(ElementMap.UserTableList));

            // Create First User cheking user doesnt exist first with Assert after creation
            Operations.AddUser(TestData.User1FirstName, TestData.User1LastName, TestData.User1UserName, TestData.User1Password, TestData.User1Customer, TestData.User1Role, TestData.User1Email, TestData.User1MobileNumber, true);

            // Create Second User cheking user doesnt exist first with Assert after creation
            Operations.AddUser(TestData.User2FirstName, TestData.User2LastName, TestData.User2UserName, TestData.User2Password, TestData.User2Customer, TestData.User2Role, TestData.User2Email, TestData.User2MobileNumber, true);
        }
    }
}
