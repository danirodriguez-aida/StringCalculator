using FluentAssertions;
using StringCalculatorProject;

namespace StringCalculatorTests {
    public class StringCalculatorShould {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void return_zero_when_string_empty()
        {
            var result = StringCalculator.Sum("");

            result.Should().Be(0);
        }

        [TestCase("1", 1, TestName = "1")]
        [TestCase("13" ,13, TestName = "13")]
        [TestCase("20", 20, TestName = "20")]
        public void return_the_same_number_when_string_only_has_this_number(string values, float expected)
        {
            var result = StringCalculator.Sum(values);

            result.Should().Be(expected);
        }
    }
}