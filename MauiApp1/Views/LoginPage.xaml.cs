namespace MauiApp1.Views;

using MauiApp1.Controls.PageControl;
using MauiApp1.ViewModels;

public partial class LoginPage : ContentPage
{
    LoginPageViewModel LoginPageVM { get; set; }

    public LoginPage(LoginPageViewModel loginPageViewModel)
	{
		InitializeComponent();

        LoginPageVM = loginPageViewModel;
        this.BindingContext = LoginPageVM;

        LoadingWrapper.Children.Add(new LoadingControl(LoginPageVM));

        LoginPageVM.IsLoading = true;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await Task.Delay(100);
        LoginPageVM.IsLoading = false;
    }
}