using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States.BacklogItemStates;

namespace AvansDevOps.Domain.Fora
{
    internal class Thread
    {
        private LinkedList<Comment> comments = new LinkedList<Comment>();
        private string topic { get; set; }
        private Person creator { get; set; }
        private BacklogItem backlogItem { get; }
        public Thread(string topic, Person creator, BacklogItem backlogItem)
        {
            this.topic = topic;
            this.creator = creator;
            this.backlogItem = backlogItem;
        }



        public void AddCommentOnThread(Comment comment)
        {
            comments.AddLast(comment);
        }

        public void RemoveCommentOfThread(Comment comment)
        {
            comments.Remove(comment);

        }

        internal bool checkIfThreadIsOpen()
        {
            return backlogItem.GetState() is BacklogItemDoneState;
        }





    }
}
