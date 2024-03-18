using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class ReleaseSprintReleaseCanceledState : IReleaseSprintState
    {
        void IReleaseSprintState.ChangeEndDate(DateTime endDate)
        {
            throw new NotImplementedException();
        }

        void IReleaseSprintState.ChangeName(string name)
        {
            throw new NotImplementedException();
        }

        void IReleaseSprintState.ChangeStartDate(DateTime startDate)
        {
            throw new NotImplementedException();
        }
    }
}
