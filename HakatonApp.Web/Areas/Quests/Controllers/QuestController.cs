namespace HakatonApp.Web.Areas.Quests.Controllers
{
    using HakatonApp.Common;
    using HakatonApp.Services;
    using HakatonApp.Services.Vauchers;
    using HakatonApp.Web.Areas.Quests.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static HakatonApp.Common.GlobalConstants;

    [Area("Quests")]
    public class QuestController : Controller
    {
        private readonly IQuestService questService;
        private readonly ISanitizerService sanitizerService;
        private readonly IImageService imageService;
        private readonly IVaucherService voucherService;

        public QuestController(IQuestService questService, ISanitizerService sanitizerService, IImageService imageService, IVaucherService voucherService)
        {
            this.voucherService = voucherService;
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
            var result = this.questService.CreateQuest(quest.Name, description, quest.StatusId, quest.DateOfQuest, quest.Image);

            if (result)
            {
                TempData["succesInfo"] = "Вие успешно добавихте инициатива!";
            }
            else
            {
                TempData["dangerInfo"] = "Възникна проблем! Опитайте отново!";
            }

            return Redirect("/Home/Index");
        }

        [Authorize]
        [Route("/Quest/Add")]
        [HttpGet]
        public IActionResult Add()
            => View(new QuestCreateFormModel());

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
            
            return null;
        }

        [Authorize(Roles = RoleAdmin + ", " + RoleEditor)]
        [Route("/Quest/Upadate/{id}")]
        [HttpGet]
        public IActionResult Update(int id)
            => View(this.questService.GetQuestById(id));

        [Authorize(Roles = RoleAdmin + ", " + RoleEditor)]
        [Route("/Quest/Approve/{id}")]
        [HttpGet]
        public IActionResult ApproveQuest()
            => View(new ApproveQuestFormModel());

        [Authorize(Roles = RoleAdmin + ", " + RoleEditor)]
        [Route("/Quest/Approve/{id}")]
        [HttpPost]
        public IActionResult ApproveQuest(int id, ApproveQuestFormModel model)
        {
            var result = this.questService.ApproveQuest(id, model.NumOfParticipants, model.PointsPerPerson);

            if (result)
            {
                this.voucherService.GenerateVauchers(id);
                TempData["succesInfo"] = "Вие успешно одобрихте инициатива!";
            }
            else
            {
                TempData["dangerInfo"] = "Възникна проблем! Опитайте отново!";
            }


            return Redirect("/Home/Index");
        }

        [Route("/Quest/Today/Approved")]
        public IActionResult TodayApprovedQuests()
            => View(this.questService.getTodayApprovedQuests());

        [Route("/Quest/Approved")]
        public IActionResult GetAllApproved()
            => View(this.questService.getApprovedQuests());

        [Route("/Quest/Waiting")]
        public IActionResult GetAllQuestsInProcess()
            => View(this.questService.getProcessingQuests());

        [Route("/Quest/All")]   
        public IActionResult GetAllQuests()
            => View(this.questService.getAllQuests());
        
        [Route("/Quest/{id}")]
        public IActionResult GetById(int id)
            => View(this.questService.GetQuestById(id));

        [Route("/Quest/Like/{id}")]
        [HttpPost]
        public IActionResult LikeQuest(int id)
        {
            this.questService.LikeQuest(id);
            
            TempData["succesInfo"] = "Вие успешно подкрепихте инициатива!";
            return Redirect("/Home/Index");
        }
    }
}
