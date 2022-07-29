namespace MauiApp1.Services;

using MauiApp1.Models;

public class LoginService : ILoginRepository
{
    //public Task<UserInfo> Login(string username, string password)
    public UserInfo Login(string username, string password)
    {
        try
        {
            if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
            {
                UserInfo userInfo = new UserInfo() { UserName = username, Password = password };
                return userInfo;
            }
            else
            {
                return null;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
