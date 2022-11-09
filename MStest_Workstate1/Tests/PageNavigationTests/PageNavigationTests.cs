using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecFlowProject_BDD.Configuration;
using SpecFlowProject_BDD.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MStest_Workstate1.PageNavigationTests {
    [TestClass]
    public class PageNavigationTests {

        [TestMethod]
        public void OpenUrlFromDriver() {
            IWebDriver driver = new ChromeDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void OpenUrlFromObjectRepository() {
            IWebDriver driver = new ChromeDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void OpenUrlFromObjectRepositoryAndGetTitle() {
            IWebDriver driver = new ChromeDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void OpenUrlFromObjectRepositoryAndGetTitleFromPageHelper() {
            IWebDriver driver = new ChromeDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            driver.Close();
            driver.Quit();
        }
    }
}
