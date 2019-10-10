using Decision.Core;
using FluentAssertions;
using Xunit;

namespace Decision.UnitTests
{
    public class BarTenderServiceShould
    {
        private readonly BarTenderService _service;

        public BarTenderServiceShould() =>
            _service = new BarTenderService(DrinkingRules.Rules);

        [Fact]
        public void Construct() =>
            _service.Should().BeOfType<BarTenderService>();

        [Theory]
        [InlineData(Gender.Male, 10, false, "Coke")]
        [InlineData(Gender.Male, 10, true, "Apple juice")]
        [InlineData(Gender.Male, 18, false, "Beer")]
        [InlineData(Gender.Male, 18, true, "Beer")]
        [InlineData(Gender.Male, 40, false, "Beer")]
        [InlineData(Gender.Male, 40, true, "Beer")]
        [InlineData(Gender.Male, 60, false, "Whiskey")]
        [InlineData(Gender.Male, 60, true, "Whiskey")]
        [InlineData(Gender.Female, 10, false, "Fanta")]
        [InlineData(Gender.Female, 10, true, "Orange juice")]
        [InlineData(Gender.Female, 18, false, "Wine")]
        [InlineData(Gender.Female, 18, true, "Wine")]
        [InlineData(Gender.Female, 31, false, "Beer")]
        [InlineData(Gender.Female, 31, true, "Beer")]
        [InlineData(Gender.Female, 55, false, "Wine")]
        [InlineData(Gender.Female, 55, true, "Wine")]
        public void ServeProperDrink(Gender gender, int age, bool hasAdhd, string expectedDrink) =>
            _service.ServeDrink(new Person { Age = age, Gender = gender, HasAdhd = hasAdhd })
                .Should().Be(expectedDrink);
    }
}