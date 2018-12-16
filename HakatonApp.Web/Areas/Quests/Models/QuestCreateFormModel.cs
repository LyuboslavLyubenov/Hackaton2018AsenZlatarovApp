namespace HakatonApp.Web.Areas.Quests.Models
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;

    public class QuestCreateFormModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int StatusId { get; set; }

        public DateTime DateOfQuest { get; set; }

        public IFormFile Image { get; set; } 
    }
}
