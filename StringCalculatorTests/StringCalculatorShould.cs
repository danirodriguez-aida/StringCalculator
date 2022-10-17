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
            var stringCalculator = new StringCalculator();

            var result = stringCalculator.Sum("");
            result.Should().Be(0);
        }
    }
}