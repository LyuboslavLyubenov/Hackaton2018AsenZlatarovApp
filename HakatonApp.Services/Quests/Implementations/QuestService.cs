using HakatonApp.Web.Data.Data;
using System;

namespace HakatonApp.Services
{
    public class QuestService : IQuestService
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

        public bool UpdateQuest(string name, string description, int statusId)
        {
            throw new System.NotImplementedException();
        }
    }
}
