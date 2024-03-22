using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.BacklogItemStates
{
    internal class BacklogItemToDoState : IBacklogItemState
    {
        private readonly BacklogItem backlogItem;

        public BacklogItemToDoState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        bool IBacklogItemState.CreatesNotification()
        {
            return false;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            Console.WriteLine("Status successfully changed to doing");
            backlogItem.SetState(new BacklogItemDoingState(backlogItem));
        }

        void IBacklogItemState.SetDoneStatus()
        {
            Console.WriteLine("Status first has to be doing");
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            Console.WriteLine("Status first has to be doing");
        }

        void IBacklogItemState.SetTestedStatus()
        {
            Console.WriteLine("Status first has to be doing");
        }

        void IBacklogItemState.SetTestingStatus()
        {
            Console.WriteLine("Status first has to be doing");
        }

        void IBacklogItemState.SetTodoStatus()
        {
            Console.WriteLine("Status is already to-do");
        }
    }
}
