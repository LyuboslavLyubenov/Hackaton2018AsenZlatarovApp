namespace HakatonApp.Web.Areas.Quests.Models
{
    using Microsoft.AspNetCore.Http;

    public class QuestCreateFormModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int StatusId { get; set; }

        public IFormFile[] Images { get; set; }
    }
}
