namespace HakatonApp.Services
{
    public interface IQuestService
    {
        bool CreateQuest(string name, string description, int statusId);

        bool UpdateQuest(string name, string description, int statusId);

        bool ApproveQuest();

        
    }
}
