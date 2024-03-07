using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemActivityTestedState : IBacklogItemActivityState
    {
        private readonly BackLogItemActivity backLogItemActivity;

        public BacklogItemActivityTestedState(BackLogItemActivity backLogItemActivity)
        {
            this.backLogItemActivity = backLogItemActivity;
        }
    }
}
