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
            var result = StringCalculator.Add("");

            result.Should().Be(0);
        }

        [TestCase("1", 1, TestName = "1")]
        [TestCase("13" ,13, TestName = "13")]
        [TestCase("20", 20, TestName = "20")]
        public void return_the_same_number_when_string_only_has_this_number(string values, int expected)
        {
            var result = StringCalculator.Add(values);

            result.Should().Be(expected);
        }

        [Test]
        public void return_the_sum_of_two_numbers_when_these_are_separated_by_comma()
        {
            var result = StringCalculator.Add("1,3");

            result.Should().Be(4);
        }

        [Test]
        public void return_the_sum_of_more_than_two_numbers_separated_by_comma()
        {
            var result = StringCalculator.Add("1,3,4");

            result.Should().Be(8);
        }
    }
}