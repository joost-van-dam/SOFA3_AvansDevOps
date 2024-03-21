using AvansDevOps.Domain.People;
using AvansDevOps.Infrastructure.Libraries;

namespace AvansDevOps.Infrastructure.Adapters
{
    internal class SlackAdapter : INotifier
    {
        private SlackLibrary slackLibrary;

        public SlackAdapter()
        {
            this.slackLibrary = new SlackLibrary();
        }

        void INotifier.SendNotification(Person person, string message)
        {
            this.slackLibrary.SendMessage($"@{person.GetFirstName}{person.GetLastName}", message);
        }
    }
}
