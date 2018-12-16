namespace HakatonApp.Services.Quests.Models
{
    using System;

    public class QuestServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PublishDate { get; set; }

        public int statusId { get; set; }

        public DateTime DateOfQuest { get; set; }

        public byte[] Image { get; set; }

        public int NumOfLikes { get; set; }
    }
}
