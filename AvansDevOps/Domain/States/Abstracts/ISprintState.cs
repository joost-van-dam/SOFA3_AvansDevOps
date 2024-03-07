namespace AvansDevOps.Domain.States.Abstracts
{
    internal interface ISprintState
    {
        void ChangeName(string name);
        void ChangeStartDate(DateTime startDate);
        void ChangeEndDate(DateTime endDate);
    }
}