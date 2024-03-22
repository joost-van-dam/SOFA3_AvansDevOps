using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.BacklogItemStates
{
    internal class BacklogItemDoingState : IBacklogItemState
    {
        private readonly BacklogItem backlogItem;

        public BacklogItemDoingState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        bool IBacklogItemState.CreatesNotification()
        {
            return false;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            Console.WriteLine("Status is already doing");
        }

        void IBacklogItemState.SetDoneStatus()
        {
            Console.WriteLine("Status first has to be ready-for-testing");
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            Console.WriteLine("Status successfully changed to ready-for-testing");

            backlogItem.SetState(new BacklogItemReadyForTestingState(backlogItem));
        }

        void IBacklogItemState.SetTestedStatus()
        {
            Console.WriteLine("Status first has to be ready-for-testing");
        }

        void IBacklogItemState.SetTestingStatus()
        {
            Console.WriteLine("Status first has to be ready-for-testing");
        }

        void IBacklogItemState.SetTodoStatus()
        {
            Console.WriteLine("Status successfully changed to to-do");
            backlogItem.SetState(new BacklogItemToDoState(backlogItem));
        }
    }
}
