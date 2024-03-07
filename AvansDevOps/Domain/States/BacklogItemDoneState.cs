using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemDoneState : IBacklogItemState
    {
        private readonly BackLogItem backLogItem;

        public BacklogItemDoneState(BackLogItem backLogItem)
        {
            this.backLogItem = backLogItem;
        }
    }
}
