namespace AvansDevOps.Domain.States.Abstracts
{
    internal interface IReleaseSprintState
    {
        void ChangeName(string name);
        void ChangeStartDate(DateTime startDate);
        void ChangeEndDate(DateTime endDate);
    }
}