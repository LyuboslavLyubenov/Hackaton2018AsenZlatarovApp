namespace HakatonApp.Data.Models
{
    public class Voucher
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public Quest Quest { get; set; }

        public int QuestId { get; set; }
    }
}
