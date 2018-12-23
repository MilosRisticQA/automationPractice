using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class HomePage
    {
        readonly IWebDriver driver;

        public By signIn = By.ClassName("login");
        public By dressesSection = By.CssSelector(".sf-menu [title='Dresses']");
        public By searchInput = By.ClassName("search_query");
        public By searchButton = By.ClassName("button-search");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("index")));         
        }
    }
}
