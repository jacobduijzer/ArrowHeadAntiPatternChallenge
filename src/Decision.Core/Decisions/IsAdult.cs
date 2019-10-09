using System;
using Decision.Core.Models;

namespace Decision.Core.Decisions
{
    public class IsAdult : IDecision<Person>
    {
        public Predicate<Person> Predicate => person => person.Age >= 18;
    }
}