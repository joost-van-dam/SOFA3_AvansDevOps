using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemActivityDoingState : IBacklogItemActivityState
    {
        private readonly BacklogItemActivity backlogItemActivity;

        public BacklogItemActivityDoingState(BacklogItemActivity backlogItemActivity)
        {
            this.backlogItemActivity = backlogItemActivity;
        }

        void IBacklogItemActivityState.SetDoingStatus()
        {
            Console.WriteLine("Status is already doing!");
        }

        void IBacklogItemActivityState.SetDoneStatus()
        {
            Console.WriteLine("Activity status changed to done!");
            this.backlogItemActivity.SetState(new BacklogItemActivityDoneState(this.backlogItemActivity));
        }

        void IBacklogItemActivityState.SetTodoStatus()
        {
            Console.WriteLine("Activity status changed to to-do!");
            this.backlogItemActivity.SetState(new BacklogItemActivityTodoState(this.backlogItemActivity));

        }
    }
}
