namespace DishLaundry.Models;

public class Message
{
    public string Text { get; set; } = string.Empty;
    public string Sender { get; set; } = string.Empty;
    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}
