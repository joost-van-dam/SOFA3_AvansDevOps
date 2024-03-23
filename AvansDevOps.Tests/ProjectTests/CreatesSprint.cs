using AvansDevOps.Domain;
using AvansDevOps.Domain.People;
using FluentAssertions;

namespace AvansDevOps.Tests.ProjectTests
{
    public class CreatesSprint
    {
        // mocks staan hier
        public CreatesSprint()
        {
            // mocks initialiseren
        }

        [Theory]
        [InlineData(TypeOfSprints.PARTIALPRODUCTSPRINT)]
        [InlineData(TypeOfSprints.RELEASESPRINT)]
        internal void CreatesSprint_AddsASprintOfTheCorrectConcreteTypeToTheSpintsListInTheProject(TypeOfSprints typeOfSprint)
        {
            // Dirty code but can not be fixed :( 
            Type concreteTypeOfSprint = null;
            if (typeOfSprint == TypeOfSprints.PARTIALPRODUCTSPRINT)
            {
                concreteTypeOfSprint = typeof(PartialProductSprint);
            }
            else if (typeOfSprint == TypeOfSprints.RELEASESPRINT)
            {
                concreteTypeOfSprint = typeof(ReleaseSprint);
            }

            // Arrange
            ProductOwner productOwner = new ProductOwner("Jan", "Jansen", "janjansen@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
            Project project = new Project(productOwner, new LinkedList<BacklogItem>());


            String name = "Sprint 1";
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(14);
            ScrumMaster scrumMaster = new ScrumMaster("Piet", "Pietersen", "pietpietersen@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
            LinkedList<Developer> developers = new LinkedList<Developer>();
            LinkedList<Tester> testers = new LinkedList<Tester>();
            LinkedList<BacklogItem> backlogitems = new LinkedList<BacklogItem>();

            // Act
            project.CreateSprint(typeOfSprint, name, startDate, endDate, scrumMaster, developers, testers, backlogitems);

            // Assert
            project.GetMostRecentSprint().Should().BeOfType(concreteTypeOfSprint);
        }
    }
}
