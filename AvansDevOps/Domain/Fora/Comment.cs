using AvansDevOps.Domain.People;

namespace AvansDevOps.Domain.Fora
{
    internal class Comment
    {
        private Thread thread;
        private string content;
        private Person author;
        private DateTime postDate;
        // comments on this comment
        private LinkedList<Comment> comments;

        public Comment(Thread thread, string content, Person author)
        {
            this.thread = thread;
            this.content = content;
            this.author = author;
            postDate = DateTime.Now;
            comments = new LinkedList<Comment>();
        }

        public string GetContent()
        {
            return content;
        }

        public Person GetAuthor()
        {
            return author;
        }

        public DateTime GetDate()
        {
            return postDate;
        }

        internal void AddCommmetOnComment(Comment comment)
        {
            comments.AddLast(comment);
        }
    }
}
