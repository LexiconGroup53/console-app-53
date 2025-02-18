namespace API.Models;

public class UserProfile
{
    public int Id { get; set; }
    public int AppUserId { get; set; }
    public AppUser User { get; set; }

    public List<string> Emails { get; set; }
    public List<string> AccountHistory { get; set; }
}