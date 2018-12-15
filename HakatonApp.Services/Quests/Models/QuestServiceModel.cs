namespace HakatonApp.Services.Quests.Models
{
    using System;

    public class QuestServiceModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PublishDate { get; set; }

        public int statusId { get; set; }
    }
}
