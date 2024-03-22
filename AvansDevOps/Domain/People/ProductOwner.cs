namespace AvansDevOps.Domain.People
{
    internal class ProductOwner : Person
    {
        public ProductOwner(string firstName, string lastName, string email, List<NotificationPlatformPreferences> preferences) : base(firstName, lastName, email, preferences)
        {
        }
    }
}
