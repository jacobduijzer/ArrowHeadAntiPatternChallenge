using Decision.Core;
using FluentAssertions;
using Xunit;

namespace Decision.UnitTests
{
    public class BarTenderServiceShould
    {
        private readonly BarTenderService _service;

        public BarTenderServiceShould() =>
            _service = new BarTenderService();

        [Fact]
        public void Construct() =>
            _service.Should().BeOfType<BarTenderService>();

        [Theory]
        [InlineData(Gender.Male, 10, false, "Coke")]
        [InlineData(Gender.Male, 10, true, "AppleJuice")]
        [InlineData(Gender.Male, 18, false, "Beer")]
        [InlineData(Gender.Male, 40, false, "Beer")]
        [InlineData(Gender.Male, 60, false, "Whiskey")]
        [InlineData(Gender.Female, 10, false, "Fanta")]
        [InlineData(Gender.Female, 10, true, "OrangeJuice")]
        [InlineData(Gender.Female, 18, false, "SweetWhiteWine")]
        [InlineData(Gender.Female, 31, false, "FruitBeer")]
        [InlineData(Gender.Female, 55, false, "RedWine")]
        public void ServeProperDrink(Gender gender, int age, bool hasAdhd, string expectedDrink) =>
            _service.ServeDrink(new Person { Age = age, Gender = gender, HasADHD = hasAdhd })
                .Should().Be(expectedDrink);
    }
}