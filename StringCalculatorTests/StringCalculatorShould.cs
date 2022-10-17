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

        [Test]
        public void return_one_when_string_only_has_one()
        {
            var result = StringCalculator.Sum("1");

            result.Should().Be(1);
        }
    }
}