using AvansDevOps.Domain;
using AvansDevOps.Domain.People;
using AvansDevOps.Domain.Strategy.Abstracts;
using Moq;

namespace AvansDevOps.Tests.SprintTests
{
    public class ExportSprintRapport
    {
        [Fact]
        internal void ExportSprintRapport_ShouldExportSprintRapport()
        {
            // Arrange
            Mock<Project> projectMock = new Mock<Project>(null, null);

            String name = "Sprint 1";
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(14);
            ScrumMaster scrumMaster = new ScrumMaster("Piet", "Pietersen", "pietpietersen@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
            LinkedList<Developer> developers = new LinkedList<Developer>();
            LinkedList<Tester> testers = new LinkedList<Tester>();
            LinkedList<BacklogItem> backlogitems = new LinkedList<BacklogItem>();

            SprintFactory sprintFactory = new SprintFactory();

            Sprint sprint = sprintFactory.CreateSprint(projectMock.Object, TypeOfSprints.PARTIALPRODUCTSPRINT, name, startDate, endDate, scrumMaster, developers, testers, backlogitems);

            Mock<ISprintRapportExportStrategy> mockStrategy = new Mock<ISprintRapportExportStrategy>();
            sprint.ChangeSprintRapportExportStrategy(mockStrategy.Object); // Change the strategy to the mocked strategy

            // Act
            sprint.ExportSprintRapport();

            // Assert
            mockStrategy.Verify(m => m.ExportSprintRapport(sprint), Times.Once());
        }
    }



}
