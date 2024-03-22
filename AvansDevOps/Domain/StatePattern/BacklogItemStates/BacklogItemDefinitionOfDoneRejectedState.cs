using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Domain.States.BacklogItemStates;

namespace AvansDevOps.Domain.StatePattern.BacklogItemStates
{
    internal class BacklogItemDefinitionOfDoneRejectedState : IBacklogItemState
    {
        private readonly BacklogItem backlogItem;

        public BacklogItemDefinitionOfDoneRejectedState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
            backlogItem.SetState(new BacklogItemReadyForTestingState(this.backlogItem));
        }

        bool IBacklogItemState.CreatesNotification()
        {
            return true;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            throw new NotImplementedException();
        }

        void IBacklogItemState.SetDoneStatus()
        {
            throw new NotImplementedException();
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            throw new NotImplementedException();
        }

        void IBacklogItemState.SetTestedStatus()
        {
            throw new NotImplementedException();
        }

        void IBacklogItemState.SetTestingStatus()
        {
            throw new NotImplementedException();
        }

        void IBacklogItemState.SetTodoStatus()
        {
            throw new NotImplementedException();
        }
    }
}
