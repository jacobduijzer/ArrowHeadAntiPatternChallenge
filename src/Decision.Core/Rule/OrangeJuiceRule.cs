using System;

namespace Decision.Core.Rule
{
    public class OrangeJuiceRule : IRule<PersonState>
    {
        public Predicate<PersonState> Predicate =>
            personState => !personState.HasFlag(PersonState.EighteenOrOlder) &&
                           !personState.HasFlag(PersonState.Male) &&
                           personState.HasFlag(PersonState.HasAdhd);
        public string Result => "Orange juice";
    }
}