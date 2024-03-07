using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemActivityDoneState : IBacklogItemActivityState
    {
        private readonly BackLogItemActivity backLogItemActivity;

        public BacklogItemActivityDoneState(BackLogItemActivity backLogItemActivity)
        {
            this.backLogItemActivity = backLogItemActivity;
        }
    }
}
