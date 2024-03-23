﻿using AvansDevOps.Domain;
using AvansDevOps.Domain.ObserverPattern.BacklogObserver;
using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Domain.States.BacklogItemStates;
using Moq;

namespace AvansDevOps.Tests.BacklogItemTests
{
    public class SetState
    {
        public SetState()
        {
        }

        [Fact]
        internal void SetState_CallsNotifyIfTheStateCreatesANotification()
        {
            // Arrange
            string name = "BacklogItem 1";
            string description = "Description of BacklogItem 1";
            Developer developer = new Developer("Bart", "Bakker", "bartbakker@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
            LinkedList<BacklogItemActivity> backlogItemActivities = new LinkedList<BacklogItemActivity>();
            BacklogItem backlogItem = new BacklogItem(name, description, developer, backlogItemActivities);

            IBacklogItemState oldState = new BacklogItemTestingRejectedState(backlogItem);

            // Create a mock observer
            var mockObserver = new Mock<IBacklogItemObserver>();
            backlogItem.Subscribe(mockObserver.Object);

            // Act
            backlogItem.SetState(oldState);

            // Assert
            mockObserver.Verify(x => x.Update(It.IsAny<BacklogItem>(), It.IsAny<IBacklogItemState>()), Times.Once);

        }

    }

    //// mocks staan hier
    //public CreatesSprint()
    //{
    //    // mocks initialiseren
    //}

    //[Theory]
    //[InlineData(TypeOfSprints.PARTIALPRODUCTSPRINT)]
    //[InlineData(TypeOfSprints.RELEASESPRINT)]
    //internal void CreatesSprint_AddsASprintOfTheCorrectConcreteTypeToTheSpintsListInTheProject(TypeOfSprints typeOfSprint)
    //{
    //    // Dirty code but can not be fixed :( 
    //    Type concreteTypeOfSprint = null;
    //    if (typeOfSprint == TypeOfSprints.PARTIALPRODUCTSPRINT)
    //    {
    //        concreteTypeOfSprint = typeof(PartialProductSprint);
    //    }
    //    else if (typeOfSprint == TypeOfSprints.RELEASESPRINT)
    //    {
    //        concreteTypeOfSprint = typeof(ReleaseSprint);
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
    //    project.GetMostRecentSprint().Should().BeOfType(concreteTypeOfSprint);
    //}
}
