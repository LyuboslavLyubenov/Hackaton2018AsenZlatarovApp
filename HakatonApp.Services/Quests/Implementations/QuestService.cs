namespace HakatonApp.Services
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using HakatonApp.Common;
    using HakatonApp.Data.Models;
    using HakatonApp.Services.Quests.Models;
    using HakatonApp.Web.Data.Data;
    using Microsoft.AspNetCore.Http;
    using System.IO;

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
        
        public bool CreateQuest(string name, string description, int statusId, DateTime dateOfEvent, IFormFile image)
        {
            try
            {
                byte[] imgArr = null;
                using (var iStr = image.OpenReadStream())
                using (var ms = new MemoryStream())
                {
                    iStr.CopyTo(ms);
                    imgArr = ms.ToArray();
                }

                this.db.Quests.Add(new Quest
                {
                    Description = description,
                    Name = name,
                    StatusId = statusId,
                    PublishDate = DateTime.UtcNow,
                    DateOfQuest = dateOfEvent,
                    Image = imgArr
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
                    Id = q.Id,
                    Name = q.Name,
                    statusId = q.StatusId,
                    Description = q.Description,
                    PublishDate = q.PublishDate,
                    DateOfQuest = q.DateOfQuest,
                    Image = q.Image
                });

        public IEnumerable<QuestServiceModel> getApprovedQuests()
            => this.db
                .Quests
                .Where(q => q.StatusId == (int)QuestStatusEnum.Approved)
                .Select(q => new QuestServiceModel
                {
                    Id = q.Id,
                    Name = q.Name,
                    Description = q.Name,
                    PublishDate = q.PublishDate,
                    statusId = q.StatusId,
                    DateOfQuest = q.DateOfQuest,
                    Image = q.Image
                })
                .ToList();

        public IEnumerable<QuestServiceModel> getNotApprovedQuests()
            => this.db
                .Quests
                .Where(q => q.StatusId == (int)QuestStatusEnum.Processing)
                .Select(q => new QuestServiceModel
                {
                    Id = q.Id,
                    Name = q.Name,
                    Description = q.Description,
                    PublishDate = q.PublishDate,
                    statusId = q.StatusId,
                    DateOfQuest = q.DateOfQuest,
                    Image = q.Image
                })
                .ToList();

        public IEnumerable<QuestServiceModel> getProcessingQuests()
            => this.db
                .Quests
                .Where(q => q.LikesNumber > GlobalConstants.NumOfLikesForProcessing)
                .Select(q => new QuestServiceModel
                {
                    Id = q.Id,
                    Name = q.Name,
                    Description = q.Description,
                    PublishDate = q.PublishDate,
                    statusId = q.StatusId,
                    DateOfQuest = q.DateOfQuest,
                    Image = q.Image
                });

        public QuestServiceModel GetQuestById(int questId)
            => this.db
                .Quests
                .Where(q => q.Id == questId)
                .Select(q => new QuestServiceModel
                {
                    Id = q.Id,
                    Name = q.Name,
                    Description = q.Description,
                    statusId = q.StatusId,
                    PublishDate = q.PublishDate,
                    DateOfQuest = q.DateOfQuest,
                    Image = q.Image,
                    NumOfLikes = q.LikesNumber
                })
                .FirstOrDefault();

        public Quest GetQuestWithHallInfoById(int questId)
            => this.db.Quests.Find(questId);

        public IEnumerable<QuestServiceModel> getTodayApprovedQuests()
            => this.db
                .Quests
                .Where(q => q.DateOfQuest == DateTime.UtcNow && q.StatusId == (int)QuestStatusEnum.Approved)
                .Select(q => new QuestServiceModel
                {
                    Id = q.Id,
                    Name = q.Name,
                    Description = q.Description,
                    PublishDate = q.PublishDate,
                    statusId = q.StatusId,
                    DateOfQuest = q.DateOfQuest
                })
                .ToList();

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
