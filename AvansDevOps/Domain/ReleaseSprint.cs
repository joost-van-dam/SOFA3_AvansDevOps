using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain
{
    internal class ReleaseSprint : Sprint
    {
        public ReleaseSprint(string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, Backlog backlog, ISprintState sprintState) : base(name, startDate, endDate, scrumMaster, developers, backlog, sprintState)
        {
        }
    }
}
