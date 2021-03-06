using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace POMPractice
{
   public class PracticePage : BasePage
    {
        public PracticePage(IWebDriver driver)
            :base(driver)
        {
        }

        private IWebElement GoogleSearchBar => Wait.Until(d => d.FindElement(By.Name("q"));

        private IWebElement SearchResult => Driver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div.r > a > h3")));

        private IWebElement SeleniumLogo => Driver.FindElement(By.XPath("//*[@id='header']/a[1]/img[1]")));
     
    }
}
