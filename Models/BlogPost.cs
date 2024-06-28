namespace WebHub.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public BlogPost()
        {

        }
    }
}
