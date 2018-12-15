namespace HakatonApp.Web.Areas.Vouchers.Controllers
{
    using HakatonApp.Services.Vauchers;
    using Microsoft.AspNetCore.Mvc;

    [Area("Voucher")]
    public class VoucherController: Controller
    {
        private readonly IVaucherService voucherService;

        public VoucherController(IVaucherService voucherService)
        {
            this.voucherService = voucherService;
        }

        public IActionResult Generate(int questId)
        {
            this.voucherService.GenerateVauchers(questId);

            return null; 
        }
    }
}
