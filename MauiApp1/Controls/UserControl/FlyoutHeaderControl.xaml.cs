namespace MauiApp1.Controls.UserControl;

using MauiApp1.Views;

public partial class FlyoutHeaderControl : ContentView
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();

        if (App.UserInfo != null)
        {
            lblUserName.Text = "Logged in as: " + App.UserInfo.UserName;
            lblUserEmail.Text = App.UserInfo.UserName;
        }
    }
}