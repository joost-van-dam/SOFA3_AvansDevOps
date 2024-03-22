using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.BacklogItemActivityStates
{
    internal class BacklogItemActivityTodoState : IBacklogItemActivityState
    {
        private readonly BacklogItemActivity backlogItemActivity;

        public BacklogItemActivityTodoState(BacklogItemActivity backlogItemActivity)
        {
            this.backlogItemActivity = backlogItemActivity;
        }

        void IBacklogItemActivityState.SetDoingStatus()
        {
            Console.WriteLine("Activity status changed to doing!");
            backlogItemActivity.SetState(new BacklogItemActivityDoingState(backlogItemActivity));
        }

        void IBacklogItemActivityState.SetDoneStatus()
        {
            Console.WriteLine("Set the status to doing first, before the status can be set to done!");
        }

        void IBacklogItemActivityState.SetTodoStatus()
        {
            Console.WriteLine("Status is already to-do!");
        }
    }
}
