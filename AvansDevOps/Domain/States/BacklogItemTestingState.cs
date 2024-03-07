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
    }
}
