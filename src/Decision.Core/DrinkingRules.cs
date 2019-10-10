using System.Collections.Generic;

namespace Decision.Core
{
    public static class DrinkingRules
    {
        public static IList<Spec<Person, string>> Rules => new List<Spec<Person, string>>
        {
            FantaFlow,
            OrangeJuiceFlow,
            CokeFlow,
            AppleJuiceFlow,
            FemaleWineFlow,
            FemaleBeerFlow,
            OlderFemaleWineFlow,
            MaleBeerFlow,
            WhiskeyFlow
        };

        public static Spec<Person, string> FantaFlow = new Spec<Person, string>()
            .WhereNot(Validators.IsAdult)
            .WhereNot(Validators.IsMale)
            .WhereNot(Validators.HasAdhd)
            .ResultsIn("Fanta");

        public static Spec<Person, string> OrangeJuiceFlow = new Spec<Person, string>()
            .WhereNot(Validators.IsAdult)
            .WhereNot(Validators.IsMale)
            .Where(Validators.HasAdhd)
            .ResultsIn("Orange juice");

        public static Spec<Person, string> CokeFlow = new Spec<Person, string>()
            .WhereNot(Validators.IsAdult)
            .Where(Validators.IsMale)
            .WhereNot(Validators.HasAdhd)
            .ResultsIn("Coke");

        public static Spec<Person, string> AppleJuiceFlow = new Spec<Person, string>()
            .WhereNot(Validators.IsAdult)
            .Where(Validators.IsMale)
            .Where(Validators.HasAdhd)
            .ResultsIn("Apple juice");

        public static Spec<Person, string> FemaleWineFlow = new Spec<Person, string>()
            .Where(Validators.IsAdult)
            .WhereNot(Validators.IsMale)
            .WhereNot(Validators.IsOlderThanThirty)
            .ResultsIn("Wine");

        public static Spec<Person, string> FemaleBeerFlow = new Spec<Person, string>()
            .Where(Validators.IsAdult)
            .WhereNot(Validators.IsMale)
            .Where(Validators.IsOlderThanThirty)
            .WhereNot(Validators.IsOlderThanFifty)
            .ResultsIn("Beer");

        public static Spec<Person, string> OlderFemaleWineFlow = new Spec<Person, string>()
            .Where(Validators.IsAdult)
            .WhereNot(Validators.IsMale)
            .Where(Validators.IsOlderThanThirty) // CAN BE REMOVED, JUST TO MAKE THE FLOW CLEAR
            .Where(Validators.IsOlderThanFifty)
            .ResultsIn("Wine");

        public static Spec<Person, string> MaleBeerFlow = new Spec<Person, string>()
            .Where(Validators.IsAdult)
            .Where(Validators.IsMale)
            .WhereNot(Validators.IsOlderThanFifty)
            .ResultsIn("Beer");

        public static Spec<Person, string> WhiskeyFlow = new Spec<Person, string>()
            .Where(Validators.IsAdult)
            .Where(Validators.IsMale)
            .Where(Validators.IsOlderThanFifty)
            .ResultsIn("Whiskey");
    }
}