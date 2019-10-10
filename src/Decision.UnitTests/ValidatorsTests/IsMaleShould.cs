using Decision.Core;
using FluentAssertions;
using Xunit;

namespace Decision.UnitTests.ValidatorsTests
{
    public class IsMaleShould
    {
        [Fact]
        public void ValidateMale() =>
            Validators.IsMale.Invoke(new Person {Gender = Gender.Male})
                .Should().BeTrue();

        [Fact]
        public void InvalidateFemale() =>
            Validators.IsMale.Invoke(new Person {Gender = Gender.Female})
                .Should().BeFalse();
    }
}