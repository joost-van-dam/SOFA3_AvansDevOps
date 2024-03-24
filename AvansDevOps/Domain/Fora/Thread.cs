using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States.BacklogItemStates;

namespace AvansDevOps.Domain.Fora
{
    internal class Thread
    {
        private readonly LinkedList<Comment> comments = new LinkedList<Comment>();
        private string topic { get; set; }
        private Person creator { get; set; }
        private readonly BacklogItem backlogItem;
        public Thread(string topic, Person creator, BacklogItem backlogItem)
        {
            this.topic = topic;
            this.creator = creator;
            this.backlogItem = backlogItem;
        }

        public void AddCommentOnThread(Comment comment)
        {
            if (CheckIfThreadIsOpen())
            {
                comments.AddLast(comment);
            }
        }

        public void RemoveCommentOfThread(Comment comment)
        {
            comments.Remove(comment);

        }

        internal bool CheckIfThreadIsOpen()
        {
            return backlogItem.GetState() is not BacklogItemDoneState;
        }

        public LinkedList<Comment> GetComments()
        {
            return comments;
        }





    }
}
