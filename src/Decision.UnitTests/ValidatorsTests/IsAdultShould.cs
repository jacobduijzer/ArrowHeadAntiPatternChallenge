using Decision.Core;
using FluentAssertions;
using Xunit;

namespace Decision.UnitTests.ValidatorsTests
{
    public class IsAdultShould
    {
        [Theory]
        [InlineData(18)]
        [InlineData(28)]
        [InlineData(38)]
        [InlineData(48)]
        [InlineData(58)]
        [InlineData(100)]
        public void ValidateAdults(int age) =>
            Validators.IsAdult.Invoke(new Person {Age = age})
                .Should().BeTrue();

        [Theory]
        [InlineData(0)]
        [InlineData(12)]
        [InlineData(17)]
        public void InvalidateYoungerThanEighteen(int age) =>
            Validators.IsAdult.Invoke(new Person {Age = age})
                .Should().BeFalse();
    }
}