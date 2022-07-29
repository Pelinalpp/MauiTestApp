namespace MauiApp1.Views;

using MauiApp1.Controls.PageControl;
using MauiApp1.ViewModels;
using System;
using System.ComponentModel;
using System.Linq;

public partial class FileSystemPage : ContentPage
{
    public FileSystemPageViewModel FileSystemPageVM { get; set; }

    public FileSystemPage(FileSystemPageViewModel fileSystemPageViewModel)
    {
        InitializeComponent();

        FileSystemPageVM = fileSystemPageViewModel;
        this.BindingContext = FileSystemPageVM;

        //LoadingWrapper.Children.Add(new LoadingControl(FileSystemPageVM));

        FileSystemPageVM.IsLoading = true;

        //MainThread.BeginInvokeOnMainThread(async () =>
        //{
        //    if(Shell.Current != null)
        //    {
        //        if (Shell.Current.Items.Count() == 1)
        //        {
        //            Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        //            {
        //                IconOverride = "menu.png"
        //            });
        //        }
        //        else
        //        {
        //            Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        //            {
        //                IconOverride = "back.png"
        //            });
        //        }
        //    }
        //});

    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        //await Task.Delay(3000);
        FileSystemPageVM.IsLoading = false;
    }

    protected override bool OnBackButtonPressed()
    {
        return base.OnBackButtonPressed();
    }
}