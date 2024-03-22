using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemTestedState : IBacklogItemState
    {
        private readonly BacklogItem backlogItem;

        public BacklogItemTestedState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        bool IBacklogItemState.CreatesNotification()
        {
            return false;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            Console.WriteLine("The status can only be set to done or ready-for-testing if the item has issuess");
        }

        void IBacklogItemState.SetDoneStatus()
        {
            Console.WriteLine("Status successfully changed to done");
            this.backlogItem.SetState(new BacklogItemDoneState(this.backlogItem));
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            Console.WriteLine("Status successfully changed to ready-for-testing");
            this.backlogItem.SetState(new BacklogItemReadyForTestingState(this.backlogItem));
        }

        void IBacklogItemState.SetTestedStatus()
        {
            Console.WriteLine("The status can only be set to done or ready-for-testing if the item has issuess");
        }

        void IBacklogItemState.SetTestingStatus()
        {
            Console.WriteLine("The status can only be set to done or ready-for-testing if the item has issuess");
        }

        void IBacklogItemState.SetTodoStatus()
        {
            Console.WriteLine("The status can only be set to done or ready-for-testing if the item has issuess");
        }
    }
}
