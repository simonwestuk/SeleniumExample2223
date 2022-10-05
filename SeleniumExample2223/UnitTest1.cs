using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumExample2223
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Users\wests\source\repos\SeleniumExample2223\SeleniumExample2223");
        }

        [Test]
        public void Check_Add()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://www.google.com"); 

            //Act
            

            //Assert
           
        }
    }
}