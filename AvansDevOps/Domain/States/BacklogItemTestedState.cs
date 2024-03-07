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
    }
}
