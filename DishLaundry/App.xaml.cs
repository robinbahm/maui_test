namespace DishLaundry;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new DishLaundry.Views.LoginPage());
    }
}
