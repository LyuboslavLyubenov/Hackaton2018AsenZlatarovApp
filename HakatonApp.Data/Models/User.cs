namespace HakatonApp.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class User: IdentityUser
    {
        [StringLength(50)]
        public string FullName { get; set; }

        public int Points { get; set; }
    }
}
