using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.signIn);
        }
        
        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.username, TestConstants.Username);
            ut.EnterTextInElement(ap.password, TestConstants.Password);
        }
        
        [StepDefinition(@"users submits the login form")]
        public void WhenUsersSubmitsTheLoginForm()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.signInBtn);
        }

        [When(@"user opens my wishlist")]
        public void WhenUserOpensMyWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage ma = new MyAccountPage(Driver);
            ut.ClickOnElement(ma.wishlist);
        }

        [Then(@"user can add new wishlist")]
        public void ThenUserCanAddNewWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyWishlistPage my = new MyWishlistPage(Driver);
            Assert.True(ut.ElementDisplayed(my.newWish), "Wish list is not displayed");
        }

        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            string email = ut.GenerateRandomEmail();
            ut.EnterTextInElement(ap.email, email);
            ut.ClickOnElement(ap.createAcc);
         
        }


        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
            Utilities ut = new Utilities(Driver);
            SignUpPage sup = new SignUpPage(Driver);
            ut.EnterTextInElement(sup.firstName, TestConstants.FirstName);
            ut.EnterTextInElement(sup.lastName, TestConstants.LastName);
            string fullname = TestConstants.FirstName + " " + TestConstants.LastName;
            ScenarioContext.Current.Add(TestConstants.FullName, fullname);
            ut.EnterTextInElement(sup.password, TestConstants.Password);
            ut.EnterTextInElement(sup.firstNameAddress, TestConstants.FirstName);
            ut.EnterTextInElement(sup.lastNameAddress, TestConstants.LastName);
            ut.EnterTextInElement(sup.address, TestConstants.Address);
            ut.EnterTextInElement(sup.city, TestConstants.City);
            ut.SelectStateDropDown(sup.state, TestConstants.State);
            ut.EnterTextInElement(sup.postcode, TestConstants.PostCode);
            ut.EnterTextInElement(sup.mobilePhone, TestConstants.MobilePhone);
            ut.EnterTextInElement(sup.addressAlias, TestConstants.AddressAlias);
           
        }


        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            Utilities ut = new Utilities(Driver);
            SignUpPage sup = new SignUpPage(Driver);
            ut.ClickOnElement(sup.registerButton);
        }




   

        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage ma = new MyAccountPage(Driver);
            Assert.True(ut.ElementDisplayed(ma.logOut), "User is not Logged in");
        }


        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            Utilities ut = new Utilities(Driver);
            string fullName = ScenarioContext.Current.Get<string>(TestConstants.FullName);
            Assert.True(ut.TextPresentInElement(fullName).Displayed, "User's full name is not displayed");
        }

    }
}
