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

        void ISprintState.ChangeEndDate(DateTime endDate)
        {
            this.sprint.endDate = endDate;
        }

        void ISprintState.ChangeName(string name)
        {
            this.sprint.name = name;
        }

        void ISprintState.ChangeStartDate(DateTime startDate)
        {
            this.sprint.startDate = startDate;
        }
    }
}
