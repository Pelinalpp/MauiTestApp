namespace MauiApp1.Models;

public class NavigationInfo
{
    public Dtype Dtype { get; set; }
    public string DirectoryPath { get; set; }
    public string RelativePath { get; set; }
    public string FolderId { get; set; }
}

public enum Dtype
{
    MyFolder,
    PrivateNetworkFolder,
    PublicNetworkFolder,
    TeamFolder,
    MyShared,
    Inbox
}
