using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class SprintCanceledState : ISprintState
    {
        private readonly Sprint sprint;

        public SprintCanceledState(Sprint sprint)
        {
            this.sprint = sprint;
        }
    }
}
