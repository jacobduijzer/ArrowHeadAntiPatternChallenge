namespace Decision.Core.Specifications
{
    public class HasADHD : AbstractSpecification<Person>
    {
        public override bool IsSatisfied(Person person) => person.HasADHD;
        public static bool Satisfied(Person person) => new HasADHD().IsSatisfied(person);
    }
}