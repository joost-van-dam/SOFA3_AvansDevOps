using AvansDevOps.Domain.People;

namespace AvansDevOps.Domain
{
    internal abstract class Sprint
    {
        internal string name; //willen we een sprint een naam geven?
        internal DateTime startDate;
        internal DateTime endDate;
        private ScrumMaster scrumMaster;
        private LinkedList<Developer> developers;
        private LinkedList<Tester> testers;
        private LinkedList<BacklogItem> backlog;


        protected Sprint(string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, LinkedList<Tester> testers, LinkedList<BacklogItem> backlog)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.scrumMaster = scrumMaster;
            this.developers = developers;
            this.testers = testers;
            this.backlog = backlog;
        }

        internal LinkedList<Developer> GetDevelopers()
        {
            return this.developers;
        }
        internal LinkedList<Tester> GetTesters()
        {
            return this.testers;
        }

        internal ScrumMaster GetScrumMaster()
        {
            return this.scrumMaster;
        }
    }
}