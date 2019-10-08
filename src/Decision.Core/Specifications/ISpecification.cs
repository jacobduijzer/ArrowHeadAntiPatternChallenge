namespace Decision.Core.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);

        ISpecification<T> And(ISpecification<T> other);
        ISpecification<T> AndNot(ISpecification<T> other);

        ISpecification<T> Not();
    }
}