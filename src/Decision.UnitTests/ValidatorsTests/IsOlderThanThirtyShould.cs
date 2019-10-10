using Decision.Core;
using FluentAssertions;
using Xunit;

namespace Decision.UnitTests.ValidatorsTests
{
    public class IsOlderThanThirtyShould
    {
        [Theory]
        [InlineData(31)]
        [InlineData(50)]
        public void ValidatePersonsOlderThanThirty(int age) =>
            Validators.IsOlderThanThirty.Invoke(new Person {Age = age})
                .Should().BeTrue();

        [Theory]
        [InlineData(30)]
        [InlineData(29)]
        [InlineData(10)]
        public void InvalidatePersonsYoungerThanThirtyOne(int age) =>
            Validators.IsOlderThanThirty.Invoke(new Person {Age = age})
                .Should().BeFalse();
    }
}