namespace Decision.Core.Extensions
{
    public static class SomeExtensions
    {
        public static bool IsEighteenOrOlder(this Person person) => person.Age >= 18;

        public static bool IsThirtyOrOlder(this Person person) => person.Age >= 30;

        public static bool IsFiftyOrOlder(this Person person) => person.Age >= 50;

        public static bool IsMale(this Person person) => person.Gender == Gender.Male;

        public static bool HasAdhdDisorder(this Person person) => person.HasAdhd;
    }
}