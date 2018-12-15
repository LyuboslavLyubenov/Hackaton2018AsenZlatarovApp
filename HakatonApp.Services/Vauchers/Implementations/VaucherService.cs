namespace HakatonApp.Services.Vauchers.Implementations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using HakatonApp.Data.Models;
    using HakatonApp.Web.Data.Data;

    public class VaucherService : IVaucherService, IService
    {
        private readonly ApplicationDbContext db;
        private readonly IRandomGenerator rnd;

        public VaucherService(ApplicationDbContext db, IRandomGenerator rnd)
        {
            this.rnd = rnd;
            this.db = db;
        }

        public bool GenerateVauchers(int questId)
        {
            try
            {
                var numOfParticipants = this.db.Quests.Select(q => q.ParticipantsNumeber).FirstOrDefault();

                for (int i = 0; i < numOfParticipants; i++)
                {
                    this.db.Vouchers.Add(new Voucher { QuestId = questId, Code = rnd.GetRandomString() });
                }

                this.db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public IEnumerable<string> GetCodes(int questId)
            => this.db
                .Vouchers
                .Where(v => v.QuestId == questId)
                .Select(v => v.Code)
                .ToList();

        public bool UseVoucher(string code)
        {
            try
            {
                var voucher = this.db.Vouchers.Where(v => v.Code == code).FirstOrDefault();
                this.db.Vouchers.Remove(voucher);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
