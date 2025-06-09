using DishLaundry.Models;

namespace DishLaundry.Services;

public class DishLaundryService
{
    private static readonly Lazy<DishLaundryService> _instance = new(() => new DishLaundryService());
    public static DishLaundryService Instance => _instance.Value;

    public User CurrentUser { get; } = new() { Name = "Alice", Age = 25, Bio = "Love cooking and cleaning" };
    private readonly List<User> _profiles = new()
    {
        new User { Name = "Bob", Age = 27, Bio = "Foodie" },
        new User { Name = "Carol", Age = 24, Bio = "Dish enthusiast" },
        new User { Name = "Dave", Age = 28, Bio = "Chef" }
    };
    public List<User> Matches { get; } = new();
    private readonly Dictionary<string, List<Message>> _chats = new();

    public User? GetNextProfile(ref int index)
    {
        if (index < _profiles.Count)
            return _profiles[index++];
        return null;
    }

    public User? LikeProfile(int index)
    {
        if (index - 1 < _profiles.Count)
        {
            var user = _profiles[index - 1];
            Matches.Add(user);
            if (!_chats.ContainsKey(user.Id))
                _chats[user.Id] = new List<Message>();
            return user;
        }
        return null;
    }

    public IEnumerable<Message> GetMessages(User user)
    {
        if (_chats.TryGetValue(user.Id, out var list))
            return list;
        return Enumerable.Empty<Message>();
    }

    public void SendMessage(User user, string text)
    {
        if (!_chats.ContainsKey(user.Id))
            _chats[user.Id] = new List<Message>();
        _chats[user.Id].Add(new Message { Text = text, Sender = CurrentUser.Name });
    }
}
