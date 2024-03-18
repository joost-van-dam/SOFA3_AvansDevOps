using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class PartialProductSprintFinishedState : IPartialProductSprintState
    {
        void IPartialProductSprintState.ChangeEndDate(DateTime endDate)
        {
            throw new NotImplementedException();
        }

        void IPartialProductSprintState.ChangeName(string name)
        {
            throw new NotImplementedException();
        }

        void IPartialProductSprintState.ChangeStartDate(DateTime startDate)
        {
            throw new NotImplementedException();
        }
    }
}
