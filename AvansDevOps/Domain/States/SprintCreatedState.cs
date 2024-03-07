using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class SprintCreatedState : ISprintState
    {
        private readonly Sprint sprint;

        public SprintCreatedState(Sprint sprint)
        {
            this.sprint = sprint;
        }
    }
}
