using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumParalleExicution
{
    public enum BrowserType
    {
        Chrome,
        FireFox,
        IE
    }

    public class Hooks : Base
    {

        private readonly BrowserType _browserType;

        public Hooks(BrowserType browser)
        {
            _browserType = browser;
        }

        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }

        [TearDown]
        public void CleanAll()
        {

            Driver.Close();
        }

        private void ChooseDriverInstance(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
                Driver = new ChromeDriver();
            else if (browserType == BrowserType.FireFox)
                Driver = new FirefoxDriver();
            else if (browserType == BrowserType.IE)
                Driver = new InternetExplorerDriver();
        }

    }
}
