using Decision.Core;
using FluentAssertions;
using Xunit;

namespace Decision.UnitTests
{
    public class PersonShould
    {
        [Fact]
        public void Construct()
            => new Person().Should().BeOfType<Person>();
    }
}