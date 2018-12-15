namespace HakatonApp.Services.Users
{
    public interface IUserService
    {
        bool AddPointsToUser(string voucherCode, string userId);

        int GetUsersPoints(int id);
    }
}
