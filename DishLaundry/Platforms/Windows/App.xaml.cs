namespace DishLaundry;

public partial class App : MauiWinUIApplication
{
    public App() : base()
    {
        InitializeComponent();
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
