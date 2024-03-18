using AvansDevOps.Domain.People;

namespace AvansDevOps.Domain
{
    internal class ReleaseSprint : Sprint
    {
        public ReleaseSprint(string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, Backlog backlog) : base(name, startDate, endDate, scrumMaster, developers, backlog/*, sprintState*/)
        {
        }
    }
}
