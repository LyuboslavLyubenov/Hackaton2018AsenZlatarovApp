namespace HakatonApp.Web.Areas.Vouchers.Controllers
{
    using HakatonApp.Services.Users;
    using HakatonApp.Services.Vauchers;
    using HakatonApp.Web.Areas.Vouchers.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using static HakatonApp.Common.GlobalConstants;
    
    [Area("Vouchers")]
    public class VoucherController: Controller
    {
        private readonly IVaucherService voucherService;
        private readonly IEmailSender emailSender;
        private readonly IUserService userService;

        public VoucherController(IVaucherService voucherService, IEmailSender emailSender)
        {
            this.emailSender = emailSender;
            this.voucherService = voucherService;
        }
        
        [Authorize(Roles = RoleAdmin + ", " + RoleEditor)]
        [HttpGet]
        [Route("/Vouchers/Generate")]
        public IActionResult Generate(int questId)
        {
            var codes = this.voucherService.GetCodes(questId);

            return View(codes);
        }

        [Authorize]
        [HttpGet]
        [Route("/Vouchers/Use")]
        public IActionResult Use()
            => View();
        
        [Authorize]
        [HttpPost]
        [Route("/Vouchers/Use")]
        public IActionResult Use(CodeFormModel model)
        {
            var result = this.voucherService.UseVoucher(model.Code);

            if (result)
            {
                TempData["succesInfo"] = "Успешно добавихте точки към профила си!";
            }
            else
            {
                TempData["dangerInfo"] = "Успешно добавихте точки към профила си!";
            }
            
            return Redirect("/Home/Index");
        }

        [Authorize(Roles = RoleAdmin + ", " + RoleEditor)]
        [Route("/Voucher/Send/{questId}")]
        [HttpGet]
        public IActionResult SendVoucher()
            => View(new EmailFormModel());

        [Authorize(Roles = RoleAdmin + ", " + RoleEditor)]
        [Route("/Voucher/Send/{questId}")]
        [HttpPost]
        public IActionResult SendVoucher(EmailFormModel model, int questId)
        {
            var vaucher = this.voucherService.GetCodes(questId).FirstOrDefault();

            if (vaucher != null)
            {
                this.emailSender.SendEmailAsync(model.Email, "Код за точки", "Здравейте, това е вашият код: " + vaucher);
            }

            TempData["succesInfo"] = "Успешно изпратихте съобщението!";

            return Redirect("/Home/Index");
        }
    }
}
