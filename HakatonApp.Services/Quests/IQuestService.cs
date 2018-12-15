namespace HakatonApp.Services
{
    using HakatonApp.Services.Quests.Models;
    using System.Collections.Generic;

    public interface IQuestService
    {
        bool CreateQuest(string name, string description, int statusId);

        bool UpdateQuest(string name, string description, int statusId);

        bool ApproveQuest();

        IEnumerable<QuestServiceModel> getApprovedQuests();

        IEnumerable<QuestServiceModel> getNotApprovedQuests();

        IEnumerable<QuestServiceModel> getAllQuests();
    }
}
