using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.ObserverPattern
{
    internal interface ISubjectBacklogItem
    {
        void Attach(IBacklogItemStateObserver observer);
        void Detach(IBacklogItemStateObserver observer);
        void Notify(BackLogItem backlogItem, IBacklogItemState newState);
    }
}
