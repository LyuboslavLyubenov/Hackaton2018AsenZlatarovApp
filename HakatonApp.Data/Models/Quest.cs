namespace HakatonApp.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Quest
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        // [Range(0, )]
        public int StatusId { get; set; }

        public int LikesNumber { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
