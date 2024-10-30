namespace TravelBlogAPI.Models
{
    public class TravelPost
    {
        public int PostID { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int AuthorID { get; set; }
        public DateTime DatePublished { get; set; }
    }
}
