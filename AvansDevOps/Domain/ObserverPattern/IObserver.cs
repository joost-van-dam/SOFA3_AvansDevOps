namespace AvansDevOps.Domain.ObserverPattern
{
    internal interface IObserver
    {
        public void Update(Notification notification);
    }
}
