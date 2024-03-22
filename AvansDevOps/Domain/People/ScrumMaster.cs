namespace AvansDevOps.Domain.People
{
    internal class ScrumMaster : Person
    {
        public ScrumMaster(string firstName, string lastName, string email, List<NotificationPlatformPreferences> preferences) : base(firstName, lastName, email, preferences)
        {
        }
    }
}
