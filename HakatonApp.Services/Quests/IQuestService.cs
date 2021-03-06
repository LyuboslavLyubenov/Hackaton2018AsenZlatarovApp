﻿namespace HakatonApp.Services
{
    using System;
    using System.Collections.Generic;
    using HakatonApp.Data.Models;
    using HakatonApp.Services.Quests.Models;
    using Microsoft.AspNetCore.Http;

    public interface IQuestService
    {
        bool CreateQuest(string name, string description, int statusId, DateTime dateOfEvent, IFormFile image);

        bool UpdateQuest(int questId, string name, string description, int statusId);

        bool ApproveQuest(int questId, int volantiersNeeded, int pointsPerPerson);

        bool RejectQuest(int questId);

        bool LikeQuest(int questId);
        
        QuestServiceModel GetQuestById(int questId);

        Quest GetQuestWithHallInfoById(int questId);

        IEnumerable<QuestServiceModel> getProcessingQuests();

        IEnumerable<QuestServiceModel> getApprovedQuests();

        IEnumerable<QuestServiceModel> getNotApprovedQuests();

        IEnumerable<QuestServiceModel> getAllQuests();

        IEnumerable<QuestServiceModel> getTodayApprovedQuests();
    }
}
