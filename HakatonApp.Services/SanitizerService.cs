using Ganss.XSS;

namespace HakatonApp.Services
{
    public class SanitizerService : ISanitizerService, IService
    {
        private readonly HtmlSanitizer sanitizer;

        public SanitizerService()
        {
            this.sanitizer = new HtmlSanitizer();
        }

        public string Sanitize(string input)
            => this.sanitizer.Sanitize(input);
    }
}
