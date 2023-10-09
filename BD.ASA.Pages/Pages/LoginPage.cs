using BD.ASA.Pages.PageInterface;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.ASA.Pages.Pages
{
    public class LoginPage : ILoginPage
    {
        //private IWebDriver _driver;

        //public LoginPage (IWebDriver driver)
        //{
        //    //this.driver = _driver;
        //}

        //IWebElement element1 => _driver.FindElement(By.Id(ElementLocators.userNameId));


        public void Login()
        {
            //element1.click();
            Console.WriteLine("This is login method from login page");
        }



        private static class ElementLocators
        {
            //ID
            public const string userNameId = "UserName";
            public const string passwordId = "password";
            public const string loginButtonId = "LoginBtn";

            //Xpath



        }
    }
}
