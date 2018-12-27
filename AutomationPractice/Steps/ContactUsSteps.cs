using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    class ContactUsSteps : Base
    {
        [Given(@"user opens contact us page")]
        public void GivenUserOpensContactUsPage()
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.contactUs);
        }

        [Given(@"fills in all required fields with '(.*)' heading and '(.*)' message")]
        public void GivenFillsInAllRequiredFieldsWithHeadingAndMessage(string p0, string p1)
        {

        }


    }
}
