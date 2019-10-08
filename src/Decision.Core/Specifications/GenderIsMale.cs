namespace Decision.Core.Specifications
{
    public class GenderIsMale : AbstractSpecification<Person>
    {
        public override bool IsSatisfied(Person person) => person.Gender == Gender.Male;
        public static bool Satisfied(Person person) => new GenderIsMale().IsSatisfied(person);
    }
}