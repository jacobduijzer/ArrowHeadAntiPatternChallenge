using System;

namespace Decision.Core.Rules
{
    public interface IRule<T>
    {
        Predicate<T> Predicate { get; }

        string Result { get; }
    }
}