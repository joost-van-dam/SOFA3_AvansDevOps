using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class ReleaseSprintCreatedState : IReleaseSprintState
    {
        private readonly Sprint sprint;

        public ReleaseSprintCreatedState(Sprint sprint)
        {
            this.sprint = sprint;
        }

        void IReleaseSprintState.ChangeEndDate(DateTime endDate)
        {
            this.sprint.endDate = endDate;
        }

        void IReleaseSprintState.ChangeName(string name)
        {
            this.sprint.name = name;
        }

        void IReleaseSprintState.ChangeStartDate(DateTime startDate)
        {
            this.sprint.startDate = startDate;
        }
    }
}
