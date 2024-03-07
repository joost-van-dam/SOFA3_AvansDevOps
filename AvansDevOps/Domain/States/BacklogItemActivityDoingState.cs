using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemActivityDoingState : IBacklogItemActivityState
    {
        private readonly BackLogItemActivity backLogItemActivity;

        public BacklogItemActivityDoingState(BackLogItemActivity backLogItemActivity)
        {
            this.backLogItemActivity = backLogItemActivity;
        }
    }
}
