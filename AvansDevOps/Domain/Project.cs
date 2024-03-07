using AvansDevOps.Domain.People;

namespace AvansDevOps.Domain
{
    internal class Project
    {
        private ProductOwner productOwner;
        private LinkedList<Sprint> sprints = new LinkedList<Sprint>();

        public Project(ProductOwner productOwner)
        {
            this.productOwner = productOwner;
        }

        public void ChangeProductOwner(ProductOwner productOwner)
        {
            this.productOwner = productOwner;
        }

        public void Add(Sprint sprint)
        {
            sprints.AddLast(sprint);
        }
    }
}
