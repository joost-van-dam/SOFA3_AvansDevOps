using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class SprintFinishedState : ISprintState
    {
        private readonly Sprint sprint;

        public SprintFinishedState(Sprint sprint)
        {
            this.sprint = sprint;
        }
    }
}
