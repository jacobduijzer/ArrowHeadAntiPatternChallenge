namespace Decision.Core.Specifications
{
    public class NotSpecification<T> : AbstractSpecification<T>
    {
        private readonly ISpecification<T> _innerSpecification;

        public NotSpecification(ISpecification<T> innerSpecification) => _innerSpecification = innerSpecification;

        public override bool IsSatisfied(T item) => !_innerSpecification.IsSatisfied(item);
    }
}