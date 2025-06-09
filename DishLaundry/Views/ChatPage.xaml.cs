using DishLaundry.Models;
using DishLaundry.Services;

namespace DishLaundry.Views;

public partial class ChatPage : ContentPage
{
    private readonly DishLaundryService _service = DishLaundryService.Instance;
    private readonly User _user;

    public ChatPage(User user)
    {
        InitializeComponent();
        _user = user;
        TitleLabel.Text = $"Chat with {user.Name}";
        MessagesList.ItemsSource = _service.GetMessages(user);
    }

    private void OnSend(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(MessageEntry.Text))
        {
            _service.SendMessage(_user, MessageEntry.Text!);
            MessageEntry.Text = string.Empty;
            MessagesList.ItemsSource = null;
            MessagesList.ItemsSource = _service.GetMessages(_user);
        }
    }
}
