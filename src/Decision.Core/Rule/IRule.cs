using System;

namespace Decision.Core.Rule
{
    public interface IRule<T>
    {
        Predicate<T> Predicate { get; }

        string Result { get; }
    }
}