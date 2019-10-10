using Decision.Core;
using FluentAssertions;
using Xunit;

namespace Decision.UnitTests.ValidatorsTests
{
    public class IsOlderThanFiftyShould
    {
        [Theory]
        [InlineData(51)]
        [InlineData(80)]
        public void ValidatePeopleOlderThanFifty(int age) =>
            Validators.IsOlderThanFifty.Invoke(new Person {Age = age})
                .Should().BeTrue();

        [Theory]
        [InlineData(50)]
        [InlineData(29)]
        [InlineData(17)]
        public void InvalidatePeopleYoungerThanFifty(int age) =>
            Validators.IsOlderThanFifty.Invoke(new Person {Age = age})
                .Should().BeFalse();
    }
}