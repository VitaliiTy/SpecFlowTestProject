using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowTestProject.Drivers;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecFlowTestProject.Steps
{
    [Binding]
    public sealed class GoogleSearchPageSteps
    {
        IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public GoogleSearchPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            driver = Driver.GetWebDriver();
        }

        [Given("Go to (.*)")]
        public void GoToPage(string page)
        {
            driver.Navigate().GoToUrl(page);
        }

        [Given("put (.*) in search bar")]
        public void PutWordInSearchBar(string word)
        {
            driver.FindElement(By.Name("q")).SendKeys(word + Keys.Enter);
        }

        [Then("the results should contain (.*)")]
        public void ThenTheResultShouldContain(string word)
        {
            IList<IWebElement> headers = driver.FindElements(By.TagName("h3"));

            for (int i = 0; i < 5; i++)
            {
                Assert.IsTrue(headers[i].Text.ToLower().Contains(word));
            } 
        }
    }
}
