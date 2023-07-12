using System;
using CalculatorApp.Support;
using TechTalk.SpecFlow;

namespace CalculatorApp.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        Calculator calculator = new Calculator();
        public int actualResult;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int FirstNumber) //50
        {
            calculator.FirstNumber =    FirstNumber;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int SecondNumber)
        {
            calculator.SecondNumber = SecondNumber;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            actualResult = calculator.Add(); // 120
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedresult) //120
        {
            actualResult.Should().Be(expectedresult);
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            actualResult = calculator.Sub(); // 120
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            actualResult = calculator.Multiply(); // 120
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            actualResult = calculator.Divide(); // 120
        }

    }
}
