namespace TravelBlogShared.Models
{
public class User
{
    public int UserID { get; set; }
    public string ?Name { get; set; }
    public string ?Email { get; set; }
    public string ?Password { get; set; }
    public DateTime DateJoined { get; set; }
}
}