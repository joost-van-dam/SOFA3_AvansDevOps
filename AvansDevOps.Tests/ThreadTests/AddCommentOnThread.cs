using AvansDevOps.Domain;
using AvansDevOps.Domain.Fora;
using AvansDevOps.Domain.People;
using AvansDevOps.Domain.StatePattern.BacklogItemStates;
using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Domain.States.BacklogItemStates;
using FluentAssertions;
using Moq;

namespace AvansDevOps.Tests.ThreadTests
{
    public class AddCommentOnThread
    {
        [Theory]
        [InlineData(typeof(BacklogItemToDoState), 1)]
        [InlineData(typeof(BacklogItemDoingState), 1)]
        [InlineData(typeof(BacklogItemReadyForTestingState), 1)]
        [InlineData(typeof(BacklogItemTestingState), 1)]
        [InlineData(typeof(BacklogItemTestingRejectedState), 1)]
        [InlineData(typeof(BacklogItemTestedState), 1)]
        [InlineData(typeof(BacklogItemDoneState), 0)]
        [InlineData(typeof(BacklogItemDefinitionOfDoneRejectedState), 1)]
        internal void AddCommentOnThread_ShouldAddCommentToThreadIfBacklogItemStatusIsNotDone(Type backlogItemState, int expectedComments)
        {
            // Arrange
            Mock<Developer> developerMock = new Mock<Developer>(null, null, null, null);
            //backlogItemMock.Setup(x => x.GetState()).Returns((IBacklogItemState)Activator.CreateInstance(backlogItemState, backlogItemMock.Object));
            BacklogItem backlogItem = new BacklogItem("BacklogItem 1", "Description of BacklogItem 1", developerMock.Object, new LinkedList<BacklogItemActivity>());

            Forum forum = new Forum();
            AvansDevOps.Domain.Fora.Thread thread = new AvansDevOps.Domain.Fora.Thread("Thread topic: een rode of blauwe banner", developerMock.Object, backlogItem);

            Comment comment = new Comment(thread, "Wil zou voor rood gaan", developerMock.Object);

            IBacklogItemState newState = (IBacklogItemState)Activator.CreateInstance(backlogItemState, backlogItem);
            backlogItem.SetState(newState);

            // Act
            thread.AddCommentOnThread(comment);

            // Assert
            //backlogItemMock.Verify(x => x.GetState(), Times.Once);
            thread.CheckIfThreadIsOpen().Should().Be(expectedComments == 1);
            thread.GetComments().Count.Should().Be(expectedComments);
        }
    }
}
