using AvansDevOps.Domain.People;

namespace AvansDevOps.Domain
{
    internal class SprintFactory
    {
        internal Sprint CreateSprint(Project project, TypeOfSprint typeOfSprint, string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, LinkedList<Tester> testers, LinkedList<BacklogItem> backlog)
        {
            return typeOfSprint switch
            {
                TypeOfSprint.PARTIALPRODUCTSPRINT => new PartialProductSprint(project, name, startDate, endDate, scrumMaster, developers, testers, backlog),
                TypeOfSprint.RELEASESPRINT => new ReleaseSprint(project, name, startDate, endDate, scrumMaster, developers, testers, backlog),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
