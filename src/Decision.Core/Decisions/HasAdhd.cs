using System;
using Decision.Core.Models;

namespace Decision.Core.Decisions
{
    public class HasAdhd : IDecision<Person>
    {
        public Predicate<Person> Predicate => person => person.HasAdhd;

        public static Predicate<Person> GetPredicate => new HasAdhd().Predicate;
    }
}