using System;

namespace Decision.Core.Decisions
{
    public interface IDecision<TSubject>
    {
        Predicate<TSubject> Predicate { get; }
    }
}