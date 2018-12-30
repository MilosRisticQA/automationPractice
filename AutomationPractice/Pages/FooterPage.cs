using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{   
    class FooterPage
    {
        readonly IWebDriver driver;

        public FooterPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("footer-container")));
        }

        public void ClickOnLink(string link)
        {
            By clickOnLink = By.CssSelector(".bullet [title='" + link + "']");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(clickOnLink)).Click();
        }

        public bool PageIsDisplayed(string page)
        {
            By elementIsDisplayed = By.XPath("//h1[contains(text(),'"+page+"')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(elementIsDisplayed)).Displayed;
        }

    }
}
