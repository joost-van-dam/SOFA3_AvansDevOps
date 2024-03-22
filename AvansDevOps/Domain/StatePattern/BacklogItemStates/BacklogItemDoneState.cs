using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.BacklogItemStates
{
    internal class BacklogItemDoneState : IBacklogItemState
    {
        private readonly BacklogItem backlogItem;

        public BacklogItemDoneState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        bool IBacklogItemState.CreatesNotification()
        {
            return false;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            Console.WriteLine("The backlog item's status is already set to done and can not be changed anymore!");
        }

        void IBacklogItemState.SetDoneStatus()
        {
            Console.WriteLine("The backlog item's status is already set to done!");
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            Console.WriteLine("The backlog item's status is already set to done and can not be changed anymore!");
        }

        void IBacklogItemState.SetTestedStatus()
        {
            Console.WriteLine("The backlog item's status is already set to done and can not be changed anymore!");
        }

        void IBacklogItemState.SetTestingStatus()
        {
            Console.WriteLine("The backlog item's status is already set to done and can not be changed anymore!");
        }

        void IBacklogItemState.SetTodoStatus()
        {
            backlogItem.SetState(new BacklogItemTestingRejectedState(backlogItem));
        }
    }
}
