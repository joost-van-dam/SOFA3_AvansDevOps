using AvansDevOps.Domain.StatePattern.BacklogItemStates;
using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.BacklogItemStates
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
            if (this.backlogItem.CheckIfAllActivitiesAreDone())
            {
                Console.WriteLine("Status successfully changed to done");
                backlogItem.SetState(new BacklogItemDoneState(backlogItem));
            }
            else
            {
                Console.WriteLine("The backlogitem has atleast one activity which status is not 'done' yet, please finish this one first before completing this item");
            }

        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            Console.WriteLine("Status successfully changed to ready-for-testing");
            backlogItem.SetState(new BacklogItemDefinitionOfDoneRejectedState(backlogItem));
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
