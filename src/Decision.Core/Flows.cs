using System.Collections.Generic;
using Decision.Core.Models;

namespace Decision.Core
{
    public static class Flows
    {
        public static IList<Spec<Person, string>> Items => new List<Spec<Person, string>>
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

        private static Spec<Person, string> FantaFlow = new Spec<Person, string>()
            .WhereNot(Validators.IsAdult)
            .WhereNot(Validators.IsMale)
            .WhereNot(Validators.HasAdhd)
            .ResultsIn("Fanta");

        private static Spec<Person, string> OrangeJuiceFlow = new Spec<Person, string>()
            .WhereNot(Validators.IsAdult)
            .WhereNot(Validators.IsMale)
            .Where(Validators.HasAdhd)
            .ResultsIn("Orange juice");

        private static Spec<Person, string> CokeFlow = new Spec<Person, string>()
            .WhereNot(Validators.IsAdult)
            .Where(Validators.IsMale)
            .WhereNot(Validators.HasAdhd)
            .ResultsIn("Coke");

        private static Spec<Person, string> AppleJuiceFlow = new Spec<Person, string>()
            .WhereNot(Validators.IsAdult)
            .Where(Validators.IsMale)
            .Where(Validators.HasAdhd)
            .ResultsIn("Apple juice");

        private static Spec<Person, string> FemaleWineFlow = new Spec<Person, string>()
            .Where(Validators.IsAdult)
            .WhereNot(Validators.IsMale)
            .WhereNot(Validators.IsOlderThanThirty)
            .ResultsIn("Wine");

        private static Spec<Person, string> FemaleBeerFlow = new Spec<Person, string>()
            .Where(Validators.IsAdult)
            .WhereNot(Validators.IsMale)
            .Where(Validators.IsOlderThanThirty)
            .WhereNot(Validators.IsOlderThanFifty)
            .ResultsIn("Beer");

        private static Spec<Person, string> OlderFemaleWineFlow = new Spec<Person, string>()
            .Where(Validators.IsAdult)
            .WhereNot(Validators.IsMale)
            .Where(Validators.IsOlderThanThirty) // CAN BE REMOVED, JUST TO MAKE THE FLOW CLEAR
            .Where(Validators.IsOlderThanFifty)
            .ResultsIn("Wine");

        private static Spec<Person, string> MaleBeerFlow = new Spec<Person, string>()
            .Where(Validators.IsAdult)
            .Where(Validators.IsMale)
            .WhereNot(Validators.IsOlderThanFifty)
            .ResultsIn("Beer");

        private static Spec<Person, string> WhiskeyFlow = new Spec<Person, string>()
            .Where(Validators.IsAdult)
            .Where(Validators.IsMale)
            .Where(Validators.IsOlderThanFifty)
            .ResultsIn("Whiskey");
    }
}