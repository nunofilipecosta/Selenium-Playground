
namespace PlaygroundSelenium.Framework
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class GooglePage
    {
        public bool IsAt
        {
            get
            {
                var h2 = Driver.Instance.FindElements(By.TagName("h2"));

                if (h2.Count > 0)
                {
                    return h2[0].Text == "Dashboard";
                }

                return false;
            }
        }

        public void Go()
        {
            Driver.Instance.Navigate().GoToUrl("https://pt.wordpress.com/wp-login.php");

            // wait a max of 10 seconds for the page load script to run
            // or wait until focus has been set on input
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(p => p.SwitchTo().ActiveElement().GetAttribute("id") == "user_login");
        }
    }
}
