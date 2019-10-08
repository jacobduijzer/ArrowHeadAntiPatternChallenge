namespace Decision.Core.Specifications
{
    public class AndSpecification<T> : AbstractSpecification<T>
    {
        private readonly ISpecification<T> _leftSpecification;
        private readonly ISpecification<T> _rightSpecification;

        public AndSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
        {
            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }

        public override bool IsSatisfied(T item) =>
            _leftSpecification.IsSatisfied(item) && _rightSpecification.IsSatisfied(item);
    }
}