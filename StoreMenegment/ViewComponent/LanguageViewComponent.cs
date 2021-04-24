using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreMenegment.IStoreService;

namespace StoreMenegment.ViewComponents
{
    public class LanguageViewComponent : ViewComponent
    {
        private IstoreManagmentService _Istore;

        public LanguageViewComponent(IstoreManagmentService Istore)
        {
            _Istore = Istore;
        }

        public IViewComponentResult Invoke()
        {
            var mm = _Istore.GetLanguage();
            return View(mm);
        }
    }
}
