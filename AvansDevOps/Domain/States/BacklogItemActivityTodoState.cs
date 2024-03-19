using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemActivityTodoState : IBacklogItemActivityState
    {
        private readonly BackLogItemActivity backLogItemActivity;

        public BacklogItemActivityTodoState(BackLogItemActivity backLogItemActivity)
        {
            this.backLogItemActivity = backLogItemActivity;
        }

        void IBacklogItemActivityState.SetDoingStatus()
        {
            Console.WriteLine("Activity status changed to doing!");
            this.backLogItemActivity.SetState(new BacklogItemActivityDoingState(this.backLogItemActivity));
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
