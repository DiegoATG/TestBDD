using BoDi;
using Coypu;
using Coypu.Drivers;
using Coypu.NUnit.Matchers;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDDTest
{
    [Binding]
    public class TestSampleStepsUX
    {
        //private readonly IObjectContainer _objectContainer;
        private BrowserSession _browser;

        [BeforeScenario]
        public void Before()
        {
            _browser = new BrowserSession(
                new SessionConfiguration
                {
                    Browser = Browser.Chrome,
                    AppHost = "google.com"
                });
           // _objectContainer.RegisterInstanceAs(_browser);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _browser.Dispose();
        }

        [Given(@"I have entered (.*) into the calculator with UX")]
        public void GivenIHaveEnteredIntoTheCalculatorWithUX(int p0)
        {
        }

        [When(@"I press add with UX")]
        public void WhenIPressAddWithUX()
        {
            _browser.Visit("/");
        }
        
        [Then(@"the result should be (.*) on the screen with UX")]
        public void ThenTheResultShouldBeOnTheScreenWithUX(int p0)
        {
            Assert.That(_browser, Shows.Content("Ofrecido por Google en: English"));
        }
    }
}
