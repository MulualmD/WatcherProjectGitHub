using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using WebDriverManager.DriverConfigs.Impl;
using WatcherProject1;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://github.com/MulualmD/WatcherProjectDemoApp/commits/master");
        }

        [Test]
            
        public void CheckIfOriginalCommitAdd()
        {
            driver.Manage().Window.Maximize();
            var ShaCommit = driver.FindElement(By.XPath("//a[@aria-label='View commit details']")).Text;
            driver.Navigate().GoToUrl($"https://github.com/MulualmD/WatcherProjectDemoApp/commit/{ShaCommit}");
            System.Threading.Thread.Sleep(3000);
            string SeleniumShaFirst = driver.FindElement(By.XPath($"//span[contains(text(),'{ShaCommit}')]")).Text;
            string lastCommitShe = Program.LastCommit();
            Assert.AreEqual(SeleniumShaFirst, lastCommitShe);
        }
        
        [Test]

        public void CheckIfSecondCommitAdd()
        {
            var ShortcutShaSecond = driver.FindElement(By.CssSelector("ol li:nth-of-type(2) div .BtnGroup a")).Text;
            driver.Navigate().GoToUrl($"https://github.com/MulualmD/WatcherProjectDemoApp/commit/{ShortcutShaSecond}");
            System.Threading.Thread.Sleep(3000);
            string SeleniumShaSecond = driver.FindElement(By.XPath($"//span[contains(text(),'{ShortcutShaSecond}')]")).Text;
            string secndCommitShe = Program.SecndCommit();
            Assert.AreEqual(SeleniumShaSecond, secndCommitShe);

        }

        [Test]
        public void CheckIfTagMade()
        {
            driver.Navigate().GoToUrl("https://github.com/MulualmD/WatcherProjectDemoApp/tags");
            var tag = driver.FindElement(By.XPath("//*[@id='repo-content-pjax-container']/div/div[2]/div[2]/div[1]/div/div/div[1]/h4/a")).Text;
            var tags = Program.AllTags();
            Assert.IsTrue(tags.Contains(tag));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}

