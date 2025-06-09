namespace DishLaundry.Views;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnCreateClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}
