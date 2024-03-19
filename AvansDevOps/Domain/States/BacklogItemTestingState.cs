using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemTestingState : IBacklogItemState
    {
        private readonly BackLogItem backLogItem;

        public BacklogItemTestingState(BackLogItem backLogItem)
        {
            this.backLogItem = backLogItem;
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
