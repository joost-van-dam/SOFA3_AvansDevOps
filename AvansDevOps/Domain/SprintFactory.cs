using AvansDevOps.Domain.People;

namespace AvansDevOps.Domain
{
    internal class SprintFactory
    {
        internal Sprint CreateSprint(Project project, TypeOfSprints typeOfSprint, string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, LinkedList<Tester> testers, LinkedList<BacklogItem> backlog)
        {
            return typeOfSprint switch
            {
                TypeOfSprints.PARTIALPRODUCTSPRINT => new PartialProductSprint(project, name, startDate, endDate, scrumMaster, developers, testers, backlog),
                TypeOfSprints.RELEASESPRINT => new ReleaseSprint(project, name, startDate, endDate, scrumMaster, developers, testers, backlog),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
