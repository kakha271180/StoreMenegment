using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreMenegment.IStoreService;

namespace StoreMenegment.Controllers
{
    public class DeliveryController : Controller
    {

        private readonly IstoreManagmentService _logger;

        public DeliveryController(IstoreManagmentService logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int LanguageId)
        {
            var language = _logger.GetLanguage().Languages.FirstOrDefault(l => l.LanguageId == LanguageId);

            if (language == null)
            {
                ViewBag.Error = "Language not found";
                return View();
            }
            ViewBag.SelectedLanguage = language.LanguageNume;
            ViewBag.FuterLanguage = LanguageId;

            return View();
        }
    }
}
