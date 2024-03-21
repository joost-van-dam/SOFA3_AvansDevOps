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

        public ProductOwner GetProductOwner()
        {
            return productOwner;
        }

        internal ScrumMaster GetScrumMaster()
        {
            return this.sprints.Last!.Value.GetScrumMaster();
        }

        public void Add(Sprint sprint)
        {
            sprints.AddLast(sprint);
        }

        public LinkedList<Developer> GetDevelopers()
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

        // straks nog en wat doen aan deze semi code duplicatie
        public LinkedList<Tester> GetTesters()
        {
            var testers = new LinkedList<Tester>();
            foreach (Sprint sprint in sprints)
            {
                foreach (Tester tester in sprint.GetTesters())
                {
                    testers.AddLast(tester);
                }
            }
            testers.Distinct();
            return testers;
        }


    }
}
