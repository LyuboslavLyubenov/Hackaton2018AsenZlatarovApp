namespace HakatonApp.Services
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using HakatonApp.Services.Quests.Models;
    using HakatonApp.Web.Data.Data;
    using HakatonApp.Common;

    public class QuestService // IQuestService
    {
        private readonly ApplicationDbContext db;

        public QuestService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public bool ApproveQuest(/*int quesrId*/)
        {
            //var quest = this.db.Quests.Find(quesrId);
            //quest.

            throw new NotImplementedException();
        }

        public bool CreateQuest(string name, string description, int statusId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<QuestServiceModel> getAllQuests()
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<QuestServiceModel> getApprovedQuests()
        //    => this.db.Quests.Where(q => q.StatusId == (int)QuestStatusEnum.Approved).ToList();

        public IEnumerable<QuestServiceModel> getNotApprovedQuests()
            => this.db
            .Quests
            .Where(q => q.StatusId == (int)QuestStatusEnum.Processing)
            .Select(q => new QuestServiceModel
            {
                Name = q.Name,
                Description = q.Description,
                PublishDate = q.PublishDate,
                statusId = q.StatusId
            })
            .ToList();

        public bool UpdateQuest(string name, string description, int statusId)
        {
            throw new System.NotImplementedException();
        }
    }
}
