using System;

namespace Decision.Core.Rule
{
    public class CokeRule : IRule<PersonState>
    {
        public Predicate<PersonState> Predicate =>
            personState => !personState.HasFlag(PersonState.EighteenOrOlder) &&
                           personState.HasFlag(PersonState.Male) &&
                           !personState.HasFlag(PersonState.HasAdhd);
        public string Result => "Coke";
    }
}