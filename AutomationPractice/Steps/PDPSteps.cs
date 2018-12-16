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
   public class PDPSteps : Base
    {
        [Given(@"user opens dresses section")]
        public void GivenUserOpensDressesSection()
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement
        }


    }
}
