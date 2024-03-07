using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemToDoState : IBacklogItemState
    {
        private readonly BackLogItem backLogItem;

        public BacklogItemToDoState(BackLogItem backLogItem)
        {
            this.backLogItem = backLogItem;
        }
    }
}
