using System;

namespace Decision.Core.Rule
{
    public class OlderFemaleWineRule : IRule<PersonState>
    {
        public Predicate<PersonState> Predicate =>
            personState => personState.HasFlag(PersonState.EighteenOrOlder) &&
                           !personState.HasFlag(PersonState.Male) &&
                           personState.HasFlag(PersonState.ThirtyOrOlder) &&
                           personState.HasFlag(PersonState.FiftyOrOlder);
        public string Result => "Wine";
    }
}