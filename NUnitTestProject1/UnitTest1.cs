
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProduct.Base;


namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests : BaseTest
    {
        [Test, Category("Create a product - Successful")]
        public void TestMethod()
        {
            IWebElement TextFiled = driver.FindElement(By.Id("create"));
            TextFiled.Click();
            IWebElement Name = driver.FindElement(By.Id("Name"));
            Name.SendKeys("JavaScript course 2020");
            IWebElement Price = driver.FindElement(By.Id("Price"));
            Price.SendKeys("11.25");
            IWebElement ImgUri1 = driver.FindElement(By.Id("ImgUri1"));
            ImgUri1.SendKeys("http");
            IWebElement Description = driver.FindElement(By.Id("Description"));
            Description.SendKeys("Description of Javascript Course wiil be defined later");
            IWebElement CreateProduct = driver.FindElement(By.Id("createProduct"));
            CreateProduct.Click();
        }

        [Test, Category("Create a product2 - Failed")]
        public void TestMethod1()
        {
            IWebElement TextFiled = driver.FindElement(By.Id("create"));
            TextFiled.Click();
            IWebElement Name = driver.FindElement(By.Id("Name"));
            Name.SendKeys("JavaScript course 2020");
            IWebElement Price = driver.FindElement(By.Id("Price"));
            Price.SendKeys("11,25");
            IWebElement ImgUri1 = driver.FindElement(By.Id("ImgUri1"));
            ImgUri1.SendKeys("http");
            IWebElement Description = driver.FindElement(By.Id("Description"));
            Description.SendKeys("Description of Javascript Course wiil be defined later");
            IWebElement CreateProduct = driver.FindElement(By.Id("createProduct"));
            CreateProduct.Click();
        }

    }
}