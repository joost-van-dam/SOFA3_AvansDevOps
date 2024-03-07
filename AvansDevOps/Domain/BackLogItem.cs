using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States;
using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain
{
    internal class BackLogItem
    {
        private string name { get; set; }
        private string description { get; set; }
        private Developer developer { get; set; } // aan Arno vragen hoe het zit met de assignment van een backlogitemactivity aan een andere developer
        private LinkedList<BackLogItemActivity> backLogItemActivities = new LinkedList<BackLogItemActivity>();
        private IBacklogItemState backlogItemState { get; set; }

        public BackLogItem(string name, string description, Developer developer, LinkedList<BackLogItemActivity> backLogItemActivities)
        {
            this.name = name;
            this.description = description;
            this.developer = developer;
            this.backLogItemActivities = backLogItemActivities;
            this.backlogItemState = new BacklogItemToDoState();
        }

        public void AddBacklogItemActivity(BackLogItemActivity backLogItemActivity)
        {
            this.backLogItemActivities.AddLast(backLogItemActivity);
        }

        public void RemoveBacklogItemActivity(BackLogItemActivity backLogItemActivity)
        {
            this.backLogItemActivities.Remove(backLogItemActivity);
        }


    }
}