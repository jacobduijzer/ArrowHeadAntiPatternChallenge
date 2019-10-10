using Decision.Core;
using FluentAssertions;
using Xunit;

namespace Decision.UnitTests.ValidatorsTests
{
    public class HasAdhd
    {
        [Fact]
        public void ValidateAdhd() =>
            Validators.HasAdhd.Invoke(new Person {HasAdhd = true})
                .Should().BeTrue();

        [Fact]
        public void InvalidateWhenNotAdhd() =>
            Validators.HasAdhd.Invoke(new Person())
                .Should().BeFalse();
    }
}