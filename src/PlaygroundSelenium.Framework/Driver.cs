namespace PlaygroundSelenium.Framework
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;

    public static class Driver
    {
        public static IWebDriver Instance { get; set; }

        /// <exception cref="OverflowException"><paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />. </exception>
        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            var timeToWait = TimeSpan.FromSeconds(5);
            Instance.Manage().Timeouts().ImplicitlyWait(timeToWait);
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
}