namespace MauiApp1.ViewModels;

using MauiApp1.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.ComponentModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    bool isLoading;

    [ObservableProperty]
    string title;
}
