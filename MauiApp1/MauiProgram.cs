namespace MauiApp1;

using MauiApp1.Controls.PageControl;
using MauiApp1.Customs;
using MauiApp1.ViewModels;
using MauiApp1.Views;
using Microsoft.Maui.Platform;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf", "FontAwesomeRegularBrand");
                fonts.AddFont("Font Awesome 6 Free-Regular-400.otf", "FontAwesomeRegular");
                fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FontAwesomeSolid");
            });

        CustomEntryHandler.Handle();

        builder.Services.AddTransient<LoadingControl>();

        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddTransient<FileSystemPage>();

        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddTransient<FileSystemPageViewModel>();

        return builder.Build();
	}
}
