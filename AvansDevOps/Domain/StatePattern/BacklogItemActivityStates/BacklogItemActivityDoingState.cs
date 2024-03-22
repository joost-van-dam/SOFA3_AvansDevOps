using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.BacklogItemActivityStates
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
            backlogItemActivity.SetState(new BacklogItemActivityDoneState(backlogItemActivity));
        }

        void IBacklogItemActivityState.SetTodoStatus()
        {
            Console.WriteLine("Activity status changed to to-do!");
            backlogItemActivity.SetState(new BacklogItemActivityTodoState(backlogItemActivity));

        }
    }
}
