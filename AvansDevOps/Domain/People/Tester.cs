namespace AvansDevOps.Domain.People
{
    internal class Tester : Person
    {
        public Tester(string firstName, string lastName, string email, List<NotificationPlatformPreferences> preferences) : base(firstName, lastName, email, preferences)
        {
        }
    }
}
