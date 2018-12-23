using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
   public class PDPSteps : Base
    {
        [Given(@"user opens dresses section")]
        public void GivenUserOpensDressesSection()
        {
            //Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            IList<IWebElement> dresses = Driver.FindElements(hp.dressesSection);
            dresses[1].Click();
        }

        [Given(@"opens first product from the list")]
        public void GivenOpensFirstProductFromTheList()
        {
            PLPPage plp = new PLPPage(Driver);
            IList<IWebElement> product = Driver.FindElements(plp.Product);
            product[2].Click();
        }

        [Given(@"inceases quantity to (.*)")]
        public void GivenInceasesQuantityTo(string qty)
        {
            Utilities ut = new Utilities(Driver);
            PDPPage pdp = new PDPPage(Driver);
            Driver.FindElement(pdp.quantity).Clear();
            ut.EnterTextInElement(pdp.quantity, qty);
            string productName = ut.ReturnTextFromElement(pdp.productName);
            ScenarioContext.Current.Add(TestConstants.ProductName, productName);
        }

        [When(@"user clicks on add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            Utilities ut = new Utilities(Driver);
            PDPPage pdp = new PDPPage(Driver);
            ut.ClickOnElement(pdp.addToCart);
        }

        [When(@"goes to checkout page")]
        public void WhenGoesToCheckoutPage()
        {
            Utilities ut = new Utilities(Driver);
            CartOverlayPage cop = new CartOverlayPage(Driver);
            ut.ClickOnElement(cop.proceedToCheckout);
        }


        [Then(@"product is added to the cart")]
        public void ThenProductIsAddedToTheCart()
        {
          
        }














    }
}
