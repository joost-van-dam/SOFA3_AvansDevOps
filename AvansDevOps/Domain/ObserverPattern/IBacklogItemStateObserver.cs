using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.ObserverPattern
{
    internal interface IBacklogItemStateObserver
    {
        public void Update(BackLogItem backlogItem, IBacklogItemState newState);
    }
}
