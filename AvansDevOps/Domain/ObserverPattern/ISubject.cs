namespace AvansDevOps.Domain.ObserverPattern
{
    internal interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(Notification notification);
    }
}
