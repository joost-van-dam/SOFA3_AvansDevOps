using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemActivityReadyForTestingState : IBacklogItemActivityState
    {
        private readonly BackLogItemActivity backLogItemActivity;

        public BacklogItemActivityReadyForTestingState(BackLogItemActivity backLogItemActivity)
        {
            this.backLogItemActivity = backLogItemActivity;
        }
    }
}
