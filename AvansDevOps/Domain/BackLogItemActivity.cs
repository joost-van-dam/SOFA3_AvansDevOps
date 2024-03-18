using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States;
using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain
{
    internal class BackLogItemActivity
    {
        private string name { get; set; }
        private string description { get; set; }
        private Developer developer { get; set; } // moet dit?
        private IBacklogItemActivityState state { get; set; }

        public BackLogItemActivity(string name, string description, Developer developer)
        {
            this.name = name;
            this.description = description;
            this.developer = developer;
            this.state = new BacklogItemActivityTodoState(this);
        }
    }
}