using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HakatonApp.Web.Models;
using HakatonApp.Services;

namespace HakatonApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuestService questService;

        public HomeController(IQuestService questService)
        {
            this.questService = questService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel()
            {
                SliderItems = new[]
                {
                    new SliderItem()
                    {
                        ImagePath = "https://cdn.discordapp.com/attachments/437165239843160064/523517124224876565/burgas5.jpg",
                        Title = "Slider item title",
                        Description = "slider item description"
                    },
                    new SliderItem()
                    {
                        ImagePath = "https://media.discordapp.net/attachments/437165239843160064/523517782743056405/csm_burgas_ch_980x302_7446f28ca6.jpg",
                        Title = "Slider item title2",
                        Description = "slider item description asljdask djsakjdjjkdjks jdks jd ksjds jksj kjjjdjskdsjk"
                    }
                },
                RecentInitiatives = new[]
                {
                    new Initiative()
                    {
                        ImagePath = "https://media.discordapp.net/attachments/437165239843160064/523530892170362880/2846269601_76c75080b4_b.jpg?width=797&height=598",
                        Title = "Slider item title 3 sadsadsadsasadd dddsldk kkk",
                    },
                    new Initiative()
                    {
                        ImagePath = "https://media.discordapp.net/attachments/437165239843160064/523530905462243328/811952329_58434117f6_z.jpg",
                        Title = "Slider item title 3 sadsadsadsasadd dddsldk kkk",
                    },
                    new Initiative()
                    {
                        ImagePath = "https://media.discordapp.net/attachments/437165239843160064/523530906934181918/12657487075_30f6cc5711_k.jpg?width=897&height=598",
                        Title = "Slider item title 3 sadsadsadsasadd dddsldk kkk",
                    },
                },
                ArchivedInitiatives = new[]
                {
                    new Initiative()
                    {
                        ImagePath = "https://media.discordapp.net/attachments/437165239843160064/523530911317360640/965554485_072c3dab8e_o.jpg?width=797&height=598",
                        Title = "Slider item title 3 sadsadsadsasadd dddsldk kkk",
                    },
                    new Initiative()
                    {
                        ImagePath = "https://media.discordapp.net/attachments/437165239843160064/523530905462243328/811952329_58434117f6_z.jpg",
                        Title = "Slider item title 3 sadsadsadsasadd dddsldk kkk",
                    },
                    new Initiative()
                    {
                        ImagePath = "https://media.discordapp.net/attachments/437165239843160064/523530906934181918/12657487075_30f6cc5711_k.jpg?width=897&height=598",
                        Title = "Slider item title 3 sadsadsadsasadd dddsldk kkk",
                    },

                    new Initiative()
                    {
                        ImagePath = "https://media.discordapp.net/attachments/437165239843160064/523530905462243328/811952329_58434117f6_z.jpg",
                        Title = "Slider item title 3 sadsadsadsasadd dddsldk kkk",
                    },
                    new Initiative()
                    {
                        ImagePath = "https://media.discordapp.net/attachments/437165239843160064/523530906934181918/12657487075_30f6cc5711_k.jpg?width=897&height=598",
                        Title = "Slider item title 3 sadsadsadsasadd dddsldk kkk",
                    },
                }
            };

            return View(viewModel);
        }

        //public IActionResult Index()
        //{
        //    var approvedQuests = this.questService.getApprovedQuests();
        //    var waithingForLikesQuests = this.questService.getProcessingQuests();


        //}

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
