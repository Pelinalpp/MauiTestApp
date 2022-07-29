namespace MauiApp1;

using MauiApp1.Models;
using MauiApp1.Views;

public partial class App : Application
{
    public static UserInfo UserInfo;

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
