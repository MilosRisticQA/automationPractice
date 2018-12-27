using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class ContactUsPage
    {
        readonly IWebDriver driver;

        public By SubjectHeading = By.Id("id_contact");
        public By Email = By.Id("email");
        public By OrderReference = By.Id("id_order");
        public By Message = By.Id("message");


        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("columns-container")));
        }
    }
}
