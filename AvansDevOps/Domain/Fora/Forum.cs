namespace AvansDevOps.Domain.Fora
{
    internal class Forum
    {
        private List<Thread> threads;

        public Forum()
        {
            threads = new List<Thread>();
        }

        public void AddThread(Thread thread)
        {
            threads.Add(thread);
        }

        public void RemoveThread(Thread thread)
        {
            threads.Remove(thread);
        }

        public List<Thread> GetThreads()
        {
            return threads;
        }
    }
}
