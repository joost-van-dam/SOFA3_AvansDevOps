using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemReadyForTestingState : IBacklogItemState
    {
        private readonly BackLogItem backLogItem;

        public BacklogItemReadyForTestingState(BackLogItem backLogItem)
        {
            this.backLogItem = backLogItem;
        }
    }
}
