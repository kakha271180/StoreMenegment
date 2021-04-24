using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreMenegment.IStoreService;
using StoreMenegment.Models;

namespace StoreMenegment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IstoreManagmentService _logger;

        public HomeController(IstoreManagmentService logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int LanguageId = 1)
        {
            var language = _logger.GetLanguage().Languages.FirstOrDefault(l => l.LanguageId == LanguageId);

            if (language == null)
            {
                ViewBag.Error = "Language not found";
                return View();
            }
            ViewBag.SelectedLanguage = language.LanguageNume;
            ViewBag.FuterLanguage = LanguageId;

            var product = _logger.GetSaleNewProductList(LanguageId);

            return View(product);
        }

        public IActionResult Privacy(int ProductSaleId, int LanguageId = 1)
        {
            var language = _logger.GetLanguage().Languages.FirstOrDefault(l => l.LanguageId == LanguageId);

            if (language == null)
            {
                ViewBag.Error = "Language not found";
                return View();
            }
            ViewBag.SelectedLanguage = language.LanguageNume;
            ViewBag.FuterLanguage = LanguageId;

            var product = _logger.GetSaleNewProductList(LanguageId).SingleOrDefault(p => p.ProductID == ProductSaleId);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
