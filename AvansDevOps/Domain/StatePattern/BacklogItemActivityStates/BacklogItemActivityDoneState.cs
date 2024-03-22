using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.BacklogItemActivityStates
{
    internal class BacklogItemActivityDoneState : IBacklogItemActivityState
    {
        private readonly BacklogItemActivity backlogItemActivity;

        public BacklogItemActivityDoneState(BacklogItemActivity backlogItemActivity)
        {
            this.backlogItemActivity = backlogItemActivity;
        }

        void IBacklogItemActivityState.SetDoingStatus()
        {
            Console.WriteLine("Activity is already done, so can not be moved to doing anymore!");
        }

        void IBacklogItemActivityState.SetDoneStatus()
        {
            Console.WriteLine("Status is already done!");
        }

        void IBacklogItemActivityState.SetTodoStatus()
        {
            Console.WriteLine("Activity is already done, so can not be moved to to-do anymore!");
        }
    }
}
