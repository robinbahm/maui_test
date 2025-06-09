using DishLaundry.Services;

namespace DishLaundry.Views;

public partial class ProfilePage : ContentPage
{
    private readonly DishLaundryService _service = DishLaundryService.Instance;

    public ProfilePage()
    {
        InitializeComponent();
        NameEntry.Text = _service.CurrentUser.Name;
        AgeEntry.Text = _service.CurrentUser.Age.ToString();
        BioEditor.Text = _service.CurrentUser.Bio;
    }

    private void OnSave(object sender, EventArgs e)
    {
        _service.CurrentUser.Name = NameEntry.Text ?? string.Empty;
        _service.CurrentUser.Age = int.TryParse(AgeEntry.Text, out var age) ? age : 0;
        _service.CurrentUser.Bio = BioEditor.Text ?? string.Empty;
        DisplayAlert("Saved", "Profile updated", "OK");
    }
}
