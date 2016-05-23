﻿using Example;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ExampleProject.Spec
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly Calculator _calculator = new Calculator();
        private int Result { get; set; }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Result = _calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.That(expectedResult, Is.EqualTo(Result));
        }
    }
}
