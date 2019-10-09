using System;
using System.Collections.Generic;
using System.Linq;

namespace Decision.Core
{
    public class Spec<TSubject, TResult>
    {
        private readonly ICollection<Predicate<TSubject>> _predicates;
        private TResult _result;

        public Spec() =>
            _predicates = new List<Predicate<TSubject>>();

        public Spec<TSubject, TResult> Where(Predicate<TSubject> additionalPredicate)
        {
            _predicates.Add(additionalPredicate);
            return this;
        }

        public Spec<TSubject, TResult> WhereNot(Predicate<TSubject> additionalPredicate)
        {
            _predicates.Add((TSubject item) => (!additionalPredicate(item)));
            return this;
        }

        public Spec<TSubject, TResult> ResultsIn(TResult result)
        {
            _result = result;
            return this;
        }

        public bool Satisfies(TSubject subject) => _predicates.All(p => p(subject));

        public TResult Result => _result;
    }
}