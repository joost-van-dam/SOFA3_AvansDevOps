namespace AvansDevOps.Domain.People
{
    internal class Developer : Person
    {
        public Developer(string firstName, string lastName, string email, List<NotificationPlatformPreferences> preferences) : base(firstName, lastName, email, preferences)
        {
        }
    }
}
