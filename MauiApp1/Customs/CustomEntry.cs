using Microsoft.Maui.Platform;

namespace MauiApp1.Customs
{
    public class CustomEntry : Entry
    {
    }

    public static class CustomEntryHandler
    {
        public static void Handle()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
            {
                if (view is CustomEntry)
                {
#if ANDROID
                    handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
#elif IOS
				    handler.PlatformView.BackgroundColor = Colors.Transparent.ToPlatform();
				    handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
                }
            });
        }
    }
}
