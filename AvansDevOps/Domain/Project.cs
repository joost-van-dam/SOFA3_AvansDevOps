using AvansDevOps.Domain.People;

namespace AvansDevOps.Domain
{
    internal class Project
    {
        private ProductOwner productOwner;
        private Backlog projectBackLog;
        private LinkedList<Sprint> sprints = new LinkedList<Sprint>();

        public Project(ProductOwner productOwner, Backlog projectBackLog)
        {
            this.productOwner = productOwner;
            this.projectBackLog = projectBackLog;
        }

        public void ChangeProductOwner(ProductOwner productOwner)
        {
            this.productOwner = productOwner;
        }

        public void Add(Sprint sprint)
        {
            sprints.AddLast(sprint);
        }

        public LinkedList<Developer> GetDeveloperList()
        {
            var developers = new LinkedList<Developer>();
            foreach (Sprint sprint in sprints)
            {
                foreach (Developer developer in sprint.GetDevelopers())
                {
                    developers.AddLast(developer);
                }
            }
            developers.Distinct();
            return developers;

        }
    }
}
