using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class SprintInProgressState : ISprintState
    {
        private readonly Sprint sprint;

        public SprintInProgressState(Sprint sprint)
        {
            this.sprint = sprint;
        }
    }
}
