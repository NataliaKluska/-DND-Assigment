namespace TravelBlogShared.Models
{
public class Booking
{
    public int BookingID { get; set; }
    public int UserID { get; set; }
    public int ServiceID { get; set; }
    public DateTime BookingDate { get; set; }
    public string ?Status { get; set; }
}
}