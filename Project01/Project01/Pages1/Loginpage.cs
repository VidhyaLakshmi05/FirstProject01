using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01.Pages1
{
    public class Loginpage
    {
        public void LoginSteps(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //launch turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(3000);


            //identify username textbox and enter valid username
            IWebElement UsernameTextbox = driver.FindElement(By.Id("UserName"));
            UsernameTextbox.SendKeys("hari");

            //identify password textbox and enter valid password
            IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
            PasswordTextbox.SendKeys("123123");

            //identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
        }
    }
}
