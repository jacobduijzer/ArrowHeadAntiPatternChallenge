using System;

namespace Decision.Core.Rule
{
    public class YoungerFemaleWineRule : IRule<PersonState>
    {
        public Predicate<PersonState> Predicate =>
            personState => personState.HasFlag(PersonState.EighteenOrOlder) &&
                           !personState.HasFlag(PersonState.Male) &&
                           !personState.HasFlag(PersonState.ThirtyOrOlder);

        public string Result => "Wine";
    }
}