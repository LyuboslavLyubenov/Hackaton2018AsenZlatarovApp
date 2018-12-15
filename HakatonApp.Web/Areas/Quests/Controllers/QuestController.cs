namespace HakatonApp.Web.Areas.Quests.Controllers
{
    using HakatonApp.Common;
    using HakatonApp.Services;
    using HakatonApp.Web.Areas.Quests.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static HakatonApp.Common.GlobalConstants;

    public class QuestController : Controller
    {
        private readonly IQuestService questService;
        private readonly ISanitizerService sanitizerService;
        private readonly IImageService imageService;

        public QuestController(IQuestService questService, ISanitizerService sanitizerService, IImageService imageService)
        {
            this.questService = questService;
            this.sanitizerService = sanitizerService;
            this.imageService = imageService;
        }

        [Authorize]
        [Route("/Quest/Add")]
        [HttpPost]
        public IActionResult Add(QuestCreateFormModel quest)
        {
            var description = this.sanitizerService.Sanitize(quest.Description);
            this.questService.CreateQuest(quest.Name, description, quest.StatusId);

            this.imageService.SaveImages(quest.Images, quest.Name);

            return View();
        }

        [Authorize]
        [Route("/Quest/Add")]
        [HttpGet]
        public IActionResult Add()
            => View();

        [Authorize(Roles = RoleAdmin + ", " + RoleEditor)]
        [Route("/Quest/Upadate/{id}")]
        [HttpPost]
        public IActionResult Update(QuestCreateFormModel quest, int id)
        {
            var description = this.sanitizerService.Sanitize(quest.Description);
            var oldQuest = this.questService.GetQuestById(id);

            oldQuest.Name = quest.Name;
            oldQuest.Description = description;
            this.questService.UpdateQuest(id, quest.Name, description, quest.StatusId);
            this.imageService.SaveImages(quest.Images, quest.Name);
            
            return View();
        }

        [Authorize(Roles = RoleAdmin + ", " + RoleEditor)]
        [Route("/Quest/Upadate/{id}")]
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(this.questService.GetQuestById(id));
        }

        [Authorize(Roles = RoleAdmin + ", " + RoleEditor)]
        [Route("/Qests/Approve")]
        [HttpPost]
        public IActionResult ApproveQuest(int id, int volantiersNeeded, int pointsPerPerson)
        {
            this.questService.ApproveQuest(id, volantiersNeeded, pointsPerPerson);

            return View();
        }
    }
}
