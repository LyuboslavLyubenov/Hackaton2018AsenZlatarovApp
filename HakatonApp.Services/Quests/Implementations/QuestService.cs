namespace HakatonApp.Services
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using HakatonApp.Common;
    using HakatonApp.Data.Models;
    using HakatonApp.Services.Quests.Models;
    using HakatonApp.Web.Data.Data;

    public class QuestService: IQuestService, IService
    {
        private readonly ApplicationDbContext db;

        public QuestService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public bool ApproveQuest(int quesrId, int volantiersNeeded, int pointsPerPerson)
        {
            try
            {
                var quest = this.db.Quests.Find(quesrId);
                quest.StatusId = (int)QuestStatusEnum.Approved;
                quest.PointsPerPartisipant = pointsPerPerson;
                quest.ParticipantsNumeber = volantiersNeeded;

                this.db.Quests.Update(quest);
                this.db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }



        public bool CreateQuest(string name, string description, int statusId)
        {
            try
            {
                this.db.Quests.Add(new Quest
                {
                    Description = description,
                    Name = name,
                    StatusId = statusId,
                    PublishDate = DateTime.UtcNow
                });

                this.db.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public IEnumerable<QuestServiceModel> getAllQuests()
            => this.db
                .Quests
                .Select(q => new QuestServiceModel
                {
                    Name = q.Name,
                    statusId = q.StatusId,
                    Description = q.Description,
                    PublishDate = q.PublishDate
                });

        public IEnumerable<QuestServiceModel> getApprovedQuests()
            => this.db
                .Quests
                .Where(q => q.StatusId == (int)QuestStatusEnum.Approved)
                .Select(q => new QuestServiceModel
                {
                    Name = q.Name,
                    Description = q.Name,
                    PublishDate = q.PublishDate,
                    statusId = q.StatusId
                })
                .ToList();

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

        public IEnumerable<QuestServiceModel> getProcessingQuests()
            => this.db
                .Quests
                .Where(q => q.LikesNumber > GlobalConstants.NumOfLikesForProcessing)
                .Select(q => new QuestServiceModel
                {
                    Name = q.Name,
                    Description = q.Description,
                    PublishDate = q.PublishDate,
                    statusId = q.StatusId
                });

        public QuestServiceModel GetQuestById(int questId)
            => this.db
                .Quests
                .Where(q => q.Id == questId)
                .Select(q => new QuestServiceModel
                {
                    Name = q.Name,
                    Description = q.Description,
                    statusId = q.StatusId,
                    PublishDate = q.PublishDate
                })
                .FirstOrDefault();

        public Quest GetQuestWithHallInfoById(int questId)
            => this.db.Quests.Find(questId);

        public bool LikeQuest(int questId)
        {
            try
            {
                var quest = this.db.Quests.Find(questId);
                quest.LikesNumber += 1;

                this.db.Quests.Update(quest);
                this.db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool RejectQuest(int questId)
        {
            try
            {
                var quest = this.db.Quests.Find(questId);
                quest.StatusId = (int)QuestStatusEnum.Rejected;
                this.db.Update(quest);

                this.db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool UpdateQuest(int questId, string name, string description, int statusId)
        {
            try
            {
                var quest = this.db.Quests.Find(questId);

                quest.Name = name;
                quest.Description = description;
                quest.StatusId = statusId;

                this.db.Quests.Update(quest);

                this.db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
