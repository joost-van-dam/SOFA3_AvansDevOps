using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemActivityTodoState : IBacklogItemActivityState
    {
        private readonly BackLogItemActivity backLogItemActivity;

        public BacklogItemActivityTodoState(BackLogItemActivity backLogItemActivity)
        {
            this.backLogItemActivity = backLogItemActivity;
        }
    }
}
