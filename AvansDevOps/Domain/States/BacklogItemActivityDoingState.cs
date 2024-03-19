using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemActivityDoingState : IBacklogItemActivityState
    {
        private readonly BackLogItemActivity backLogItemActivity;

        public BacklogItemActivityDoingState(BackLogItemActivity backLogItemActivity)
        {
            this.backLogItemActivity = backLogItemActivity;
        }

        void IBacklogItemActivityState.SetDoingStatus()
        {
            Console.WriteLine("Status is already doing!");
        }

        void IBacklogItemActivityState.SetDoneStatus()
        {
            Console.WriteLine("Activity status changed to done!");
            this.backLogItemActivity.SetState(new BacklogItemActivityDoneState(this.backLogItemActivity));
        }

        void IBacklogItemActivityState.SetTodoStatus()
        {
            Console.WriteLine("Activity status changed to to-do!");
            this.backLogItemActivity.SetState(new BacklogItemActivityTodoState(this.backLogItemActivity));

        }
    }
}
