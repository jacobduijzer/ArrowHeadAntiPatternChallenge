using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Bogus;
using Decision.Core;
using Decision.Core.Models;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;
using Person = Decision.Core.Models.Person;

namespace Decision.UnitTests
{
    public class BarTenderServiceShould
    {
        private readonly ITestOutputHelper _output;
        private readonly BarTenderService _service;

        public BarTenderServiceShould(ITestOutputHelper output)
        {
            _output = output;
            _service = new BarTenderService(Flows.Items);
        }

        [Fact]
        public void Construct() =>
            _service.Should().BeOfType<BarTenderService>();

        [Theory]
        [InlineData(Gender.Male, 10, false, "Coke")]
        [InlineData(Gender.Male, 10, true, "Apple juice")]
        [InlineData(Gender.Male, 18, false, "Beer")]
        [InlineData(Gender.Male, 40, false, "Beer")]
        [InlineData(Gender.Male, 60, false, "Whiskey")]
        [InlineData(Gender.Female, 10, false, "Fanta")]
        [InlineData(Gender.Female, 10, true, "Orange juice")]
        [InlineData(Gender.Female, 18, false, "Wine")]
        [InlineData(Gender.Female, 31, false, "Beer")]
        [InlineData(Gender.Female, 55, false, "Wine")]
        public void ServeProperDrink(Gender gender, int age, bool hasAdhd, string expectedDrink) =>
            _service.ServeDrink(new Person { Age = age, Gender = gender, HasAdhd = hasAdhd })
                .Should().Be(expectedDrink);

        [Fact]
        public void Perform()
        {
            var people = new Faker<Person>()
                .RuleFor(x => x.Age, (faker, person) => faker.Random.Int(4, 90))
                .RuleFor(x => x.FirstName, (faker, person) => faker.Person.FirstName)
                .RuleFor(x => x.LastName, (faker, person) => faker.Person.LastName)
                .RuleFor(x => x.Gender, (faker, person) => faker.PickRandom(Gender.Female, Gender.Male))
                .RuleFor(x => x.HasAdhd, (faker, person) => faker.PickRandom(true, false))
                .Generate(1000000);

            Stopwatch sw = new Stopwatch();
            Dictionary<string, int> record = new Dictionary<string, int>();
            sw.Start();
            people.ForEach(person =>
            {
                var result = _service.ServeDrink(person);
                if (record.ContainsKey(result))
                    record[result]++;
                else
                    record[result] = 1;
            });

            sw.Stop();
            _output.WriteLine($"Elapsed={sw.Elapsed}");

            foreach (var keyValuePair in record)
                _output.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
        }
    }
}