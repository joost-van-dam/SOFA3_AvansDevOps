using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemTestedState : IBacklogItemState
    {
        private readonly BackLogItem backLogItem;

        public BacklogItemTestedState(BackLogItem backLogItem)
        {
            this.backLogItem = backLogItem;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            Console.WriteLine("The status can only be set to done or ready-for-testing if the item has issuess");
        }

        void IBacklogItemState.SetDoneStatus()
        {
            Console.WriteLine("Status successfully changed to done");
            this.backLogItem.SetState(new BacklogItemDoneState(this.backLogItem));
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            Console.WriteLine("Status successfully changed to ready-for-testing");
            this.backLogItem.SetState(new BacklogItemReadyForTestingState(this.backLogItem));
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
