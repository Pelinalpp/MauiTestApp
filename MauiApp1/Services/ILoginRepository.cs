namespace MauiApp1.Services;

using MauiApp1.Models;

public interface ILoginRepository
{
    //Task<UserInfo> Login(string username, string password);
    UserInfo Login(string username, string password);
}
