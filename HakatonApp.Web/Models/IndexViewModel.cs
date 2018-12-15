namespace HakatonApp.Web.Models
{
    public class IndexViewModel
    {
        public SliderItem[] SliderItems { get; set; }

        public Initiative[] TopInitiatives { get; set; }

        public Initiative[] RecentInitiatives { get; set; }

        public Initiative[] ArchivedInitiatives { get; set; }
    }
}