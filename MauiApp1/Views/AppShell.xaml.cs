namespace MauiApp1.Views;

using MauiApp1.Models;
using MauiApp1.ViewModels;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //this.Navigating += AppShellNavigating;

        this.BindingContext = new AppShellViewModel();
        Routing.RegisterRoute("Second" + nameof(FileSystemPage), typeof(FileSystemPage));

        flname.Items.Add(new ShellContent() { Title = "My Folder", Content = new FileSystemPage(new FileSystemPageViewModel() { NavigationInfo = new NavigationInfo() { Dtype = Dtype.MyFolder }, Title = "My Folder", PageCount = 0, FolderName = "Page 0" }) });
        flname.Items.Add(new ShellContent() { Title = "Private Network Folder", Content = new FileSystemPage(new FileSystemPageViewModel() { NavigationInfo = new NavigationInfo() { Dtype = Dtype.PrivateNetworkFolder }, Title = "Private Network Folder", PageCount = 0, FolderName = "Page 0" }) });
        flname.Items.Add(new ShellContent() { Title = "Public Network Folder", Content = new FileSystemPage(new FileSystemPageViewModel() { NavigationInfo = new NavigationInfo() { Dtype = Dtype.PublicNetworkFolder }, Title = "Public Network Folder", PageCount = 0, FolderName = "Page 0" }) });
        flname.Items.Add(new ShellContent() { Title = "Team Folder", Content = new FileSystemPage(new FileSystemPageViewModel() { NavigationInfo = new NavigationInfo() { Dtype = Dtype.TeamFolder }, Title = "Team Folder", PageCount = 0, FolderName = "Page 0" }) });
        flname.Items.Add(new ShellContent() { Title = "My Shared", Content = new FileSystemPage(new FileSystemPageViewModel() { NavigationInfo = new NavigationInfo() { Dtype = Dtype.MyShared }, Title = "My Shared", PageCount = 0, FolderName = "Page 0" }) });
        flname.Items.Add(new ShellContent() { Title = "Inbox", Content = new FileSystemPage(new FileSystemPageViewModel() { NavigationInfo = new NavigationInfo() { Dtype = Dtype.Inbox }, Title = "Inbox", PageCount = 0, FolderName = "Page 0" }) });
        flname.Items.Add(new ShellContent() { Title = "My Links", Content = new MyLinksPage() });
        flname.Items.Add(new ShellContent() { Title = "Recycle", Content = new RecyclePage() });
        flname.Items.Add(new ShellContent() { Title = "Notifications", Content = new NotificationsPage() });
        flname.Items.Add(new ShellContent() { Title = "Downloads", Content = new DownloadPage() });
        flname.Items.Add(new ShellContent() { Title = "My Settings", Content = new MySettingsPage() });
    }

    //public void AppShellNavigating(object sender, ShellNavigatingEventArgs e)
    //{
    //    MainThread.BeginInvokeOnMainThread(async () =>
    //    {
    //        try
    //        {
    //            Shell s = sender as Shell;
    //            var item = s.CurrentItem;

    //            var Location = e.Target.Location.OriginalString;

    //            if (Location.Contains("SecondFileSystemPage"))
    //            {
    //                s.FlyoutIcon = "back.png";
    //            }
    //            else
    //            {
    //                s.FlyoutIcon = "menu.png";
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            string message = ex.Message;
    //        }
    //    });
    //}
}
