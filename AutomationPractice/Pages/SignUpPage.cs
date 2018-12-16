using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class SignUpPage
    {

        readonly IWebDriver driver;

        public By firstName = By.Id("customer_firstname");
        public By lastName = By.Id("customer_lastname");
        public By password = By.Id("passwd");
        public By firstNameAddress = By.Id("firstname");
        public By lastNameAddress = By.Id("lastname");
        public By address = By.Id("address1");
        public By city = By.Id("city");
        public By state = By.Id("id_state");
        public By postcode = By.Id("postcode");
        public By mobilePhone = By.Id("phone_mobile");
        public By addressAlias = By.Id("alias");
        public By registerButton = By.Id("submitAccount");


        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("account-creation_form")));
                            
        }
    }
}
