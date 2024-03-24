using AvansDevOps.Domain;
using AvansDevOps.Domain.ObserverPattern.BacklogObserver;
using AvansDevOps.Domain.People;
using AvansDevOps.Domain.StatePattern.BacklogItemStates;
using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Domain.States.BacklogItemStates;
using FluentAssertions;
using Moq;

namespace AvansDevOps.Tests.BacklogItemTests
{
    public class SetState
    {
        public SetState()
        {
        }

        [Theory]
        [InlineData(typeof(BacklogItemToDoState), 0)]
        [InlineData(typeof(BacklogItemDoingState), 0)]
        [InlineData(typeof(BacklogItemReadyForTestingState), 0)]
        [InlineData(typeof(BacklogItemTestingState), 0)]
        [InlineData(typeof(BacklogItemTestingRejectedState), 1)]
        [InlineData(typeof(BacklogItemTestedState), 0)]
        [InlineData(typeof(BacklogItemDoneState), 0)]
        [InlineData(typeof(BacklogItemDefinitionOfDoneRejectedState), 1)]
        internal void SetState_CallsNotifyIfTheStateCreatesANotification(Type stateType, int expectedTimesCalled)
        {
            Mock<Sprint> sprintMock = new Mock<Sprint>(null, null, null, null, null, null, null, null);

            // Arrange
            string name = "BacklogItem 1";
            string description = "Description of BacklogItem 1";
            Developer developer = new Developer("Bart", "Bakker", "bartbakker@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
            LinkedList<BacklogItemActivity> backlogItemActivities = new LinkedList<BacklogItemActivity>();
            BacklogItem backlogItem = new BacklogItem(sprintMock.Object, name, description, developer, backlogItemActivities);

            IBacklogItemState newState = (IBacklogItemState)Activator.CreateInstance(stateType, backlogItem);

            // Create a mock observer
            var mockObserver = new Mock<IBacklogItemObserver>();
            backlogItem.Subscribe(mockObserver.Object);

            // Act
            backlogItem.SetState(newState);

            // Assert
            if (expectedTimesCalled == 0)
            {
                mockObserver.Verify(x => x.Update(It.IsAny<BacklogItem>(), It.IsAny<IBacklogItemState>()), Times.Never);
            }
            else if (expectedTimesCalled == 1)
            {
                mockObserver.Verify(x => x.Update(It.IsAny<BacklogItem>(), It.IsAny<IBacklogItemState>()), Times.Once);
            }
            backlogItem.GetState().Should().BeOfType(stateType);
        }

        [Fact]
        internal void SetDoingState_SetsTheStateToDoing()
        {
            Mock<Sprint> sprintMock = new Mock<Sprint>(null, null, null, null, null, null, null, null);

            // Arrange
            string name = "BacklogItem 1";
            string description = "Description of BacklogItem 1";
            Developer developer = new Developer("Bart", "Bakker", "bartbakker@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
            LinkedList<BacklogItemActivity> backlogItemActivities = new LinkedList<BacklogItemActivity>();
            BacklogItem backlogItem = new BacklogItem(sprintMock.Object, name, description, developer, backlogItemActivities);

            // Act
            backlogItem.SetDoingState();

            // Assert
            backlogItem.GetState().Should().BeOfType(typeof(BacklogItemDoingState));
        }

        [Fact]
        internal void SetReadyForTestingState_ShouldSetStateToReadyForTestingAfterWhenCurrentStateIsDoing()
        {
            Mock<Sprint> sprintMock = new Mock<Sprint>(null, null, null, null, null, null, null, null);

            // Arrange
            string name = "BacklogItem 1";
            string description = "Description of BacklogItem 1";
            Developer developer = new Developer("Bart", "Bakker", "bartbakker@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
            LinkedList<BacklogItemActivity> backlogItemActivities = new LinkedList<BacklogItemActivity>();
            BacklogItem backlogItem = new BacklogItem(sprintMock.Object, name, description, developer, backlogItemActivities);
            backlogItem.SetDoingState();

            // Act
            backlogItem.SetReadyForTestingState();

            // Assert
            backlogItem.GetState().Should().BeOfType(typeof(BacklogItemReadyForTestingState));
        }

        [Fact]
        internal void SetReadyForTestingState_ShouldNotSetStateToReadyForTestingAfterWhenCurrentStateIsToDo()
        {
            Mock<Sprint> sprintMock = new Mock<Sprint>(null, null, null, null, null, null, null, null);

            // Arrange
            string name = "BacklogItem 1";
            string description = "Description of BacklogItem 1";
            Developer developer = new Developer("Bart", "Bakker", "bartbakker@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
            LinkedList<BacklogItemActivity> backlogItemActivities = new LinkedList<BacklogItemActivity>();
            BacklogItem backlogItem = new BacklogItem(sprintMock.Object, name, description, developer, backlogItemActivities);

            // Act
            backlogItem.SetReadyForTestingState();

            // Assert
            backlogItem.GetState().Should().BeOfType(typeof(BacklogItemToDoState));
        }

        [Fact]
        internal void SetXState_ShouldNotSetTheStateToAnythingElseBesidesDoingOrCanceledWhenCurrentStateIsToDo()
        {
            Mock<Sprint> sprintMock = new Mock<Sprint>(null, null, null, null, null, null, null, null);

            // Arrange
            string name = "BacklogItem 1";
            string description = "Description of BacklogItem 1";
            Developer developer = new Developer("Bart", "Bakker", "bartbakker@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
            LinkedList<BacklogItemActivity> backlogItemActivities = new LinkedList<BacklogItemActivity>();
            BacklogItem backlogItem = new BacklogItem(sprintMock.Object, name, description, developer, backlogItemActivities);

            // Act
            backlogItem.SetReadyForTestingState();
            backlogItem.SetTestingState();
            backlogItem.SetTestedState();
            backlogItem.SetDoneState();

            // Assert
            backlogItem.GetState().Should().BeOfType(typeof(BacklogItemToDoState));
        }

        [Fact]
        internal void SetXState_ShouldNotSetTheStateToAnythingElseBesidesDoingOrCanceledWhenCurrentStateIsDoing()
        {
            Mock<Sprint> sprintMock = new Mock<Sprint>(null, null, null, null, null, null, null, null);

            // Arrange
            string name = "BacklogItem 1";
            string description = "Description of BacklogItem 1";
            Developer developer = new Developer("Bart", "Bakker", "bartbakker@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
            LinkedList<BacklogItemActivity> backlogItemActivities = new LinkedList<BacklogItemActivity>();
            BacklogItem backlogItem = new BacklogItem(sprintMock.Object, name, description, developer, backlogItemActivities);

            // Act
            backlogItem.SetTestingState();
            backlogItem.SetTestedState();
            backlogItem.SetDoneState();

            // Assert
            backlogItem.GetState().Should().BeOfType(typeof(BacklogItemToDoState));
        }

    }

}
