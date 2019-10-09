using System;
using Decision.Core.Models;

namespace Decision.Core
{
    public static class Validators
    {
        public static Predicate<Person> IsAdult => person => person.Age >= 18;
        public static Predicate<Person> IsMale => person => person.Gender == Gender.Male;
        public static Predicate<Person> HasAdhd => person => person.HasAdhd;
        public static Predicate<Person> IsOlderThanThirty => person => person.Age > 30;
        public static Predicate<Person> IsOlderThanFifty => person => person.Age > 50;
    }
}