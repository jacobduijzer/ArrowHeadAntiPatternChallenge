using System;

namespace Decision.Core
{
    public class DrinkingRule
    {
        public DrinkingRule(Predicate<Person> predicate, string drink)
        {
            Predicate = predicate;
            Drink = drink;
        }

        public Predicate<Person> Predicate { get; }
        public string Drink { get; }
    }
}