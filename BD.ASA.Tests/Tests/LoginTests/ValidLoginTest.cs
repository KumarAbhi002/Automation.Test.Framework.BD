using BD.ASA.Pages;
using NUnit.Framework;
using BD.ASA.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.ASA.Infrastructure.ElementActions;

namespace BD.ASA.Tests.Tests.LoginTests
{
    [TestFixture]
    public class ValidLoginTest : BaseTest
    {
        PageRepository pageRepo = new PageRepository();
        ElementActions elementActions = new ElementActions();

        string _name = "Abhi";

        [SetUp] 
        public void TestSetup()
        {
            Console.WriteLine(" this is TestSetup");
        }

        [Test]
        [Order(0)]
        [Category("Login")]
        [Category("Regression")]
        [Author("Abhishek")]
        [Description("To Validate that the valid login should be successfull")]
        public void ASA_1234_ValidLoginTest()
        {

            Console.WriteLine(" ASA_1234_ValidLoginTest ");
            pageRepo.loginPage.Login();
            elementActions.Click(_name);

        }


        [TearDown] 
        public void TestTearDown() 
        {
            Console.WriteLine("TestTearDown ");
        }   
    }
}
