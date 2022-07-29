namespace MauiApp1.ViewModels;

using MauiApp1.Controls.UserControl;
using MauiApp1.Models;
using MauiApp1.Services;
using MauiApp1.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;

public partial class LoginPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private string userName = "pelin";

    [ObservableProperty]
    private string password = "test";

    readonly ILoginRepository loginRepository = new LoginService();

    [ICommand]
    public void Login()
    {
        IsLoading = true;

        _ = Task.Run(() =>
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                //await Task.Delay(3000);
                if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
                {
                    UserInfo userInfo = loginRepository.Login(UserName, Password);

                    if (Preferences.ContainsKey(nameof(App.UserInfo)))
                    {
                        Preferences.Remove(nameof(App.UserInfo));
                    }

                    string userDetails = JsonConvert.SerializeObject(userInfo);
                    Preferences.Set(nameof(App.UserInfo), userDetails);
                    App.UserInfo = userInfo;

                    AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

                    await Shell.Current.GoToAsync($"//{nameof(FileSystemPage)}?Title=My Folder&FolderName=Page 0",
                                new Dictionary<string, object>
                                {
                                    ["NavigationInfo"] = new NavigationInfo() { Dtype = Dtype.MyFolder }
                                });
                }
                IsLoading = false;
            });
        });


    }
}
