using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Domain.States.BacklogItemActivityStates;

namespace AvansDevOps.Domain
{
    internal class BacklogItemActivity
    {
        private string name { get; set; }
        private string description { get; set; }
        private Developer developer { get; set; }
        private IBacklogItemActivityState backlogItemActivityState { get; set; }

        public BacklogItemActivity(string name, string description, Developer developer)
        {
            this.name = name;
            this.description = description;
            this.developer = developer;
            this.backlogItemActivityState = new BacklogItemActivityTodoState(this);
        }

        //methodes om te veranderen van state!
        public void SetDoingStatus()
        {
            this.backlogItemActivityState.SetDoingStatus();
        }

        public void SetDoneStatus()
        {
            this.backlogItemActivityState.SetDoneStatus();
        }

        public void SetTodoStatus()
        {
            this.backlogItemActivityState.SetTodoStatus();
        }

        internal void SetState(IBacklogItemActivityState state)
        {
            this.backlogItemActivityState = state;
        }

        internal IBacklogItemActivityState GetState()
        {
            return this.backlogItemActivityState;
        }
    }
}