namespace DishLaundry.Models;

public class Match
{
    public User User { get; set; } = default!;
    public DateTime MatchedOn { get; set; } = DateTime.UtcNow;
}
