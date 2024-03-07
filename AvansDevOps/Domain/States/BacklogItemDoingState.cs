using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemDoingState : IBacklogItemState
    {
        private readonly BackLogItem backLogItem;

        public BacklogItemDoingState(BackLogItem backLogItem)
        {
            this.backLogItem = backLogItem;
        }
    }
}
