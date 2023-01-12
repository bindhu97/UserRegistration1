using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration1;
using Assert = NUnit.Framework.Assert;

namespace UserTest
{
    public class Tests
    {
        [TestMethod]
        public void ValidateFirstName()
        {
            //Arrange
            RegistrationOfUser user = new RegistrationOfUser();
            string expected = "Bindu";
            //Act
            string firstname = "Bindhu";
            //Assert
            Assert.AreEqual(expected, firstname);
        }

        [TestMethod]
        public void ValidateLastName()
        {
            //Arrange
            RegistrationOfUser validate = new RegistrationOfUser();
            string expected = "Sree";
            //Act
            string LastName = "Shree";
            //Assert
            Assert.AreEqual(expected, LastName);
        }
        
        [TestMethod]
        public void ValidateEmail()
        {
            //Arrange
            RegistrationOfUser validate = new RegistrationOfUser();
            string expected = "Bindu%45@gmail.com";
            //Act
            string EmailId = "Bindu!97@gmail.com.in";
            //Assert
            Assert.AreEqual(expected, EmailId);
        }
        
        [TestMethod]
        public void ValidateNumber()
        {
            //Arrange
            RegistrationOfUser validate = new RegistrationOfUser();
            string expected = "91 8765432976";
            //Act
            string MobileNo = "91 6958334551";
            //Assert
            Assert.AreEqual(expected, MobileNo);
        }
        
        [TestMethod]
        public void ValidatePassword()
        {
            //Arrange
            RegistrationOfUser validate = new RegistrationOfUser();
            string expected = "Bind45#qw";
            //Act
            string PassWord4 = "Bin97@mD";
            //Assert
            Assert.AreEqual(expected, PassWord4);
        }
        [TestMethod]
        [DataRow("Bin321@gmail.com")]
        [DataRow("Bin987@gmail.com.in")]
        [DataRow("Bin.97@gmail.com")]
        [DataRow("Bin123@gml.com")]
        [DataRow("Bin.089@gmail.com.in")]
        public void Validate_Multiple_Email_Enteries(string EmailId)
        {
            //Arrange
            RegistrationOfUser user = new RegistrationOfUser();
            bool expected = true;
            //Act
            bool result = user.Equals(EmailId);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}