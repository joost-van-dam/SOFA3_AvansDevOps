using AvansDevOps.Domain.People;
using AvansDevOps.Infrastructure.Libraries;

namespace AvansDevOps.Infrastructure.Adapters
{
    internal class SlackAdapter
    {
        private SlackLibrary slackLibrary;

        public SlackAdapter()
        {
            this.slackLibrary = new SlackLibrary();
        }

        public void SendMessage(Developer developer, string message)
        {
            this.slackLibrary.SendMessage($"@{developer.GetFirstName}{developer.GetLastName}", message);
        }
    }
}
