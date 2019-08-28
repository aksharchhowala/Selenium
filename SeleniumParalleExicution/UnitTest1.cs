using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;


namespace SeleniumParalleExicution
{
    [TestFixture]
    [Parallelizable]
    public class FireFoxTestExicution : Hooks
    {
        public FireFoxTestExicution() : base(BrowserType.FireFox)
        { }

        [Test]
        public void FireFoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/webhp?hl=en&sa=X&ved=0ahUKEwibj7mC1KXkAhVMzaQKHXi-Cv8QPAgH");
            Driver.FindElement(By.Name("q")).SendKeys("FireFox");
            Thread.Sleep(1000);
            Driver.FindElement(By.Name("btnK")).Submit();
            Assert.That(
                Driver.PageSource.Contains("FireFox"), Is.EqualTo(true),
                "The text selenium dosnt exist");
        }
    }

    [TestFixture]
    [Parallelizable]
    public class ChromeTestExicution : Hooks
    {
        public ChromeTestExicution() : base(BrowserType.Chrome)
        { }

        [Test]
        public void ChromeGoogleTest()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/webhp?hl=en&sa=X&ved=0ahUKEwibj7mC1KXkAhVMzaQKHXi-Cv8QPAgH");
            Driver.FindElement(By.Name("q")).SendKeys("Chrome");
            Thread.Sleep(1000);
            Driver.FindElement(By.Name("btnK")).Submit();
            Assert.That(
                Driver.PageSource.Contains("Chrome"), Is.EqualTo(true), 
                "The text selenium dosnt exist");
        }
    }

}
