namespace MauiApp1.ViewModels;

using MauiApp1.Views;
using Microsoft.Toolkit.Mvvm.Input;

public partial class AppShellViewModel : BaseViewModel
{
    [ICommand]
    async void SignOut()
    {
        if (Preferences.ContainsKey(nameof(App.UserInfo)))
        {
            Preferences.Remove(nameof(App.UserInfo));
        }
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}
