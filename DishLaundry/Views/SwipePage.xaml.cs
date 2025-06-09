using DishLaundry.Models;
using DishLaundry.Services;

namespace DishLaundry.Views;

public partial class SwipePage : ContentPage
{
    private readonly DishLaundryService _service = DishLaundryService.Instance;
    private int _currentIndex = 0;

    public SwipePage()
    {
        InitializeComponent();
        UpdateProfile();
    }

    private void UpdateProfile()
    {
        var profile = _service.GetNextProfile(ref _currentIndex);
        if (profile != null)
            ProfileLabel.Text = $"{profile.Name}, {profile.Age}";
        else
            ProfileLabel.Text = "No more profiles";
    }

    private void OnPass(object sender, EventArgs e)
    {
        UpdateProfile();
    }

    private void OnLike(object sender, EventArgs e)
    {
        var profile = _service.LikeProfile(_currentIndex);
        if (profile != null)
            DisplayAlert("Match", $"You matched with {profile.Name}!", "OK");
        UpdateProfile();
    }
}
