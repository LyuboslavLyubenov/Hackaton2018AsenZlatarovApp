namespace HakatonApp.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Quest
    {
        public int Id { get; set; }

        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        [StringLength(500)]
        [Required]
        public string Description { get; set; }

        [Range(0, 3)]
        public int StatusId { get; set; }

        public int LikesNumber { get; set; }

        public DateTime PublishDate { get; set; }

        public int ParticipantsNumeber { get; set; }

        public int PointsPerPartisipant { get; set; }
    }
}
