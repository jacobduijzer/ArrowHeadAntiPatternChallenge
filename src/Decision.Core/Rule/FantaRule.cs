using System;

namespace Decision.Core.Rule
{
    public class FantaRule : IRule<PersonState>
    {
        public Predicate<PersonState> Predicate =>
            personState => !personState.HasFlag(PersonState.EighteenOrOlder) &&
                           !personState.HasFlag(PersonState.Male) &&
                           !personState.HasFlag(PersonState.HasAdhd);

        public string Result => "Fanta";
    }
}