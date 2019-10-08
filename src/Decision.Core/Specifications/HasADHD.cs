namespace Decision.Core.Specifications
{
    public class HasADHD : AbstractSpecification<Person>
    {
        public override bool IsSatisfied(Person person) => person.HasADHD;
    }
}