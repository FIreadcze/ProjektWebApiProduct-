using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiProduct.Base
{
    public class BaseTest
    {
        public IWebDriver driver;
        //onetimeSetUp -pouze jednou
        //set up otevre ted browser pokazde pred kazdym testcasem
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44348/CompanyProducts";
        }
        [TearDown]
        public void close()
        {
            driver.Quit();

        }
    }
}
