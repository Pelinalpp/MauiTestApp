namespace MauiApp1.ViewModels;

using MauiApp1.Models;
using MauiApp1.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

[QueryProperty(nameof(Title), nameof(Title))]
[QueryProperty(nameof(PageCount), nameof(PageCount))]
[QueryProperty(nameof(FolderName), nameof(FolderName))]
[QueryProperty(nameof(NavigationInfo), nameof(NavigationInfo))]
public partial class FileSystemPageViewModel : BaseViewModel
{
    [ObservableProperty]
    string folderName;

    [ObservableProperty]
    private NavigationInfo navigationInfo;

    [ObservableProperty]
    private int pageCount;

    [ICommand]
    public async void GoNextPage()
    {
        IsLoading = true;
        //await Task.Delay(3000);
        PageCount++;
        var newFolderName = "Page " + (PageCount).ToString();
        await Shell.Current.GoToAsync($"Second{nameof(FileSystemPage)}?Title={Title}&PageCount={PageCount}&FolderName={newFolderName}",
                        new Dictionary<string, object>
                        {
                            ["NavigationInfo"] = new NavigationInfo() { Dtype = Dtype.MyFolder, DirectoryPath = newFolderName }
                        });

        IsLoading = false;
    }
}
