using BDDTest.Core;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDDTest
{
    [Binding]
    public class TestSampleSteps
    {
        private Calculator calculator = new Calculator();

        private int result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            calculator.newNumber(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            this.result = calculator.addNumbers();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedNumber)
        {
            Assert.AreEqual(expectedNumber, result);
        }
    }
}
