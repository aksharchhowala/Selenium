using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumParalleExicution
{
    [TestFixture]
    public class Base
    {
        public IWebDriver Driver { get; set; }
    }

}
