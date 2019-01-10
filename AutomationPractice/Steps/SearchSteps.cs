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

        public class SearchSteps : Base
    {
        [Given(@"user enters '(.*)' in search")]
        public void GivenUserEntersInSearch(string keyword)
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.EnterTextInElement(hp.searchInput, keyword);
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
            
            SearchPage sp = new SearchPage(Driver);
            IList<IWebElement> titles = Driver.FindElements(sp.ProductTitle);
            int resultsCount = titles.Count;

            for (int i = 0; i < resultsCount -1; i++)
            {
                string title = titles[i].GetAttribute("title");
                bla bala
                Assert.True(title.Contains(keyword), "Keyword we searched '" + keyword + "' is not in related element title");
            }
            
            
        }

    }
}
