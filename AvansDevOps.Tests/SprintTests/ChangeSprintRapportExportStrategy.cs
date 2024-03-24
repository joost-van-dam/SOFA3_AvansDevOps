using AvansDevOps.Domain;
using AvansDevOps.Domain.People;
using AvansDevOps.Domain.Strategy;
using AvansDevOps.Domain.StrategyPattern;
using FluentAssertions;
using Moq;

namespace AvansDevOps.Tests.SprintTests
{
    public class ChangeSprintRapportExportStrategy
    {

        [Theory]
        [InlineData(SprintRapportExportTypes.PDF)]
        [InlineData(SprintRapportExportTypes.PNG)]
        internal void ChangeSprintRapportExportStrategy_ShouldSetExportStrategyToRightStrategy(SprintRapportExportTypes sprintRapportExportTypes)
        {
            // Dirty code but can not be fixed :( 
            Type expectedSprintRapportExportStrategy = null;
            if (sprintRapportExportTypes == SprintRapportExportTypes.PDF)
            {
                expectedSprintRapportExportStrategy = typeof(SprintPDFRapportExportStrategy);
            }
            else if (sprintRapportExportTypes == SprintRapportExportTypes.PNG)
            {
                expectedSprintRapportExportStrategy = typeof(SprintPNGRapportExportStrategy);
            }

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

            // Act
            sprint.ChangeSprintRapportExportStrategy(sprintRapportExportTypes);

            // Assert
            sprint.GetSprintRapportExportStrategy().Should().BeOfType(expectedSprintRapportExportStrategy);


        }



        //[Theory]
        //[InlineData(TypeOfSprints.PARTIALPRODUCTSPRINT)]
        //[InlineData(TypeOfSprints.RELEASESPRINT)]
        //internal void CreatesSprint_AddsASprintOfTheCorrectConcreteTypeToTheSpintsListInTheProject(TypeOfSprints typeOfSprint)
        //{
        //    // Dirty code but can not be fixed :( 
        //    Type expectedConcreteTypeOfSprint = null;
        //    if (typeOfSprint == TypeOfSprints.PARTIALPRODUCTSPRINT)
        //    {
        //        expectedConcreteTypeOfSprint = typeof(PartialProductSprint);
        //    }
        //    else if (typeOfSprint == TypeOfSprints.RELEASESPRINT)
        //    {
        //        expectedConcreteTypeOfSprint = typeof(ReleaseSprint);
        //    }

        //    // Arrange
        //    ProductOwner productOwner = new ProductOwner("Jan", "Jansen", "janjansen@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
        //    Project project = new Project(productOwner, new LinkedList<BacklogItem>());


        //    String name = "Sprint 1";
        //    DateTime startDate = DateTime.Now;
        //    DateTime endDate = DateTime.Now.AddDays(14);
        //    ScrumMaster scrumMaster = new ScrumMaster("Piet", "Pietersen", "pietpietersen@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
        //    LinkedList<Developer> developers = new LinkedList<Developer>();
        //    LinkedList<Tester> testers = new LinkedList<Tester>();
        //    LinkedList<BacklogItem> backlogitems = new LinkedList<BacklogItem>();

        //    // Act
        //    project.CreateSprint(typeOfSprint, name, startDate, endDate, scrumMaster, developers, testers, backlogitems);

        //    // Assert
        //    project.GetMostRecentSprint().Should().BeOfType(expectedConcreteTypeOfSprint);
        //}
    }
}
