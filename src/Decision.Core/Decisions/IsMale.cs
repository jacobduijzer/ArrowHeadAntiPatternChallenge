using System;
using Decision.Core.Models;

namespace Decision.Core.Decisions
{
    public class IsMale : IDecision<Person>
    {
        public Predicate<Person> Predicate => person => person.Gender == Gender.Male;
    }
}