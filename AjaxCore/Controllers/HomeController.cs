using AjaxCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AjaxCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetirHepsi()
        {
            using var context = new Context();
            var Kullanicilar =context.Kullanicilar.ToList();

            var JsonData = JsonConvert.SerializeObject(Kullanicilar);
            return Json(JsonData);

        }

        public IActionResult GetirId(int KullaniciId)
        {
            using var context = new Context();
            var Kullanici = context.Kullanicilar.FirstOrDefault( I => I.ID==KullaniciId);
            return Json(JsonConvert.SerializeObject(Kullanici));
        }
    }
}
