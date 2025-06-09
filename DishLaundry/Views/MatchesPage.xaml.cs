using DishLaundry.Services;
using DishLaundry.Models;

namespace DishLaundry.Views;

public partial class MatchesPage : ContentPage
{
    private readonly DishLaundryService _service = DishLaundryService.Instance;

    public MatchesPage()
    {
        InitializeComponent();
        MatchesList.ItemsSource = _service.Matches;
    }

    private async void OnMatchSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is User user)
        {
            await Navigation.PushAsync(new ChatPage(user));
            MatchesList.SelectedItem = null;
        }
    }
}
