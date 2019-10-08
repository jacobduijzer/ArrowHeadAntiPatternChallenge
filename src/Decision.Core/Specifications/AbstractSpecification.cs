namespace Decision.Core.Specifications
{
    public abstract class AbstractSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfied(T item);

        public ISpecification<T> And(ISpecification<T> other) =>
            new AndSpecification<T>(this, other);
        
        public ISpecification<T> AndNot(ISpecification<T> other) =>
            And(other.Not());
        
        public ISpecification<T> AndNot<TSpec>()
            where TSpec : ISpecification<T>, new() =>
            And(new TSpec().Not());

        public ISpecification<T> Not() =>
            new NotSpecification<T>(this);
    }
}