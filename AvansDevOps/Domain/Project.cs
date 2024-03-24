using AvansDevOps.Domain.People;

namespace AvansDevOps.Domain
{
    internal class Project
    {
        private ProductOwner productOwner;
        private readonly LinkedList<BacklogItem> projectBacklog = new LinkedList<BacklogItem>();
        private readonly LinkedList<Sprint> sprints = new LinkedList<Sprint>();
        private readonly SprintFactory sprintFactory = new SprintFactory();
        public Project(ProductOwner productOwner, LinkedList<BacklogItem> projectBacklog)
        {
            this.productOwner = productOwner;
            this.projectBacklog = projectBacklog;
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

        public void CreateSprint(TypeOfSprints typeOfSprint, string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, LinkedList<Tester> testers, LinkedList<BacklogItem> backlogtems)
        {
            this.sprints.AddLast(this.sprintFactory.CreateSprint(this, typeOfSprint, name, startDate, endDate, scrumMaster, developers, testers, backlogtems));
        }

        public void AddBacklogItem(BacklogItem backlogItem)
        {
            this.projectBacklog.AddLast(backlogItem);
        }

        public BacklogItem GetBacklogItem(string name)
        {
            foreach (BacklogItem backlogItem in projectBacklog)
            {
                if (backlogItem.GetName() == name)
                {
                    return backlogItem;
                }
            }
            return null;
        }

        public LinkedList<BacklogItem> GetBacklogItems()
        {
            return this.projectBacklog;
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
            return testers;
        }

        public Sprint GetMostRecentSprint()
        {
            if (sprints.Last != null)
            {
                return sprints.Last.Value;

            }
            return null;
        }


    }
}
