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
            // Arrange
            string name = "BacklogItem 1";
            string description = "Description of BacklogItem 1";
            Developer developer = new Developer("Bart", "Bakker", "bartbakker@avansdevops.nl", new List<NotificationPlatformPreferences> { NotificationPlatformPreferences.EMAIL });
            LinkedList<BacklogItemActivity> backlogItemActivities = new LinkedList<BacklogItemActivity>();
            BacklogItem backlogItem = new BacklogItem(name, description, developer, backlogItemActivities);

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

    }

}
