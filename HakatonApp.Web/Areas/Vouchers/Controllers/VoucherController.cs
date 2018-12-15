namespace HakatonApp.Web.Areas.Vouchers.Controllers
{
    using HakatonApp.Services.Users;
    using HakatonApp.Services.Vauchers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static HakatonApp.Common.GlobalConstants;
    public class VoucherController: Controller
    {
        private readonly IVaucherService voucherService;
        private readonly IUserService userService;

        public VoucherController(IVaucherService voucherService)
        {
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


        [Authorize()]
        [HttpPost]
        [Route("/Vouchers/Use")]
        public IActionResult Use(string voucherCode)
        {
            this.voucherService.UseVoucher(voucherCode);
            
            return null;
        }
    }
}
