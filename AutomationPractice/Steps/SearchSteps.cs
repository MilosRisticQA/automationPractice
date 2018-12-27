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

        public class SearchSteps : Base
    {
        [Given(@"user enters '(.*)' in search")]
        public void GivenUserEntersInSearch(string keyword)
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.EnterTextInElement(hp.searchInput, keyword);
            string searchKeyword = ut.ReturnTextFromElement(hp.searchInput);
            ScenarioContext.Current.Add(TestConstants.SearchKeyword, searchKeyword);
        }

        [Given(@"user submits search")]
        public void GivenUserSubmitsSearch()
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.searchButton);
        }

        [Then(@"search by keyword '(.*)' is done")]
        public void ThenSearchByKeywordIsDone(string keyword)
        {
            Utilities ut = new Utilities(Driver);
            PLPPage plp = new PLPPage(Driver);
            string searchKeyword = ScenarioContext.Current.Get<string>(TestConstants.SearchKeyword);
            Assert.That(ut.ReturnTextFromElement(plp.Keyword).Contains(searchKeyword), "Keyword is not matched");
        }

    }
}
