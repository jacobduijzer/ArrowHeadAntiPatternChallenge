using System;

namespace Decision.Core.Rule
{
    public class MaleBeerRule : IRule<PersonState>
    {
        public Predicate<PersonState> Predicate =>
            personState => personState.HasFlag(PersonState.EighteenOrOlder) &&
                           personState.HasFlag(PersonState.Male) &&
                           !personState.HasFlag(PersonState.FiftyOrOlder);

        public string Result => "Beer";
    }
}