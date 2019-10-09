using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace circleCI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
	        IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://cloud.google.com");
            Thread.Sleep(3000);
            Console.WriteLine("the page is opened");
            driver.Quit();
            Console.WriteLine("the page is closed");
        }
    }
}
