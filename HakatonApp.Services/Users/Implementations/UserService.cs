namespace HakatonApp.Services.Users.Implementations
{
    using System;
    using System.Linq;
    using HakatonApp.Web.Data.Data;

    public class UserService: IUserService, IService
    {
        private readonly ApplicationDbContext db;

        public UserService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public bool AddPointsToUser(string voucherCode, string userId)
        {
            try
            {
                var voucher = this.db.Vouchers.Where(v => v.Code == voucherCode).FirstOrDefault();

                var user = this.db.Users.Find(userId);
                user.Points += voucher.Quest.PointsPerPartisipant;

                this.db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public int GetUsersPoints(int id)
            => this.db.Users.Find(id).Points;
    }
}
