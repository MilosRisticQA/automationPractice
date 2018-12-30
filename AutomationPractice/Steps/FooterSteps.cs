using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class FooterSteps : Base
    {
        FooterPage fp = new FooterPage(Driver);

        [When(@"user clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string myAccLink)
        {
            fp.ClickOnLink(myAccLink);
        }

        [Then(@"correct '(.*)' is displayed")]
        public void ThenCorrectIsDisplayed(string page)
        {
            Assert.True(fp.PageIsDisplayed(page), "Page is not displayed");
        }


    }
}
