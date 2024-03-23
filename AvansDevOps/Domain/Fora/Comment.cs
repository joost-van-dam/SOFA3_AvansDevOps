using AvansDevOps.Domain.People;

namespace AvansDevOps.Domain.Fora
{
    internal class Comment
    {
        private readonly Thread thread;
        private string content;
        private readonly Person author;
        private readonly DateTime postDate;
        // comments on this comment
        private readonly LinkedList<Comment> comments;

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

        public void ChangeContent(string content)
        {
            this.content = content;
        }

        internal void AddCommmetOnComment(Comment comment)
        {
            comments.AddLast(comment);
        }
    }
}
