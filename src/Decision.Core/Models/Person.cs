namespace Decision.Core.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public bool HasAdhd { get; set; }
    }
}