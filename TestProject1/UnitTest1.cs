using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1
{
    public class Tests :Program
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://github.com/mosmo46/DemoApp/commits/master");
            string ShaCommit = driver.FindElement(By.XPath("//a[@aria-label='View commit details']")).Text;
            string lastCommit = Program
            Assert.True(lastCommit.Contains(ShaCommit));

            Assert.Pass();
        }
    }
}