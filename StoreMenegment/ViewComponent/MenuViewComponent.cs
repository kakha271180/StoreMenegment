using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreMenegment.IStoreService;

namespace StoreMenegment.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private IstoreManagmentService _Istore;
        public MenuViewComponent(IstoreManagmentService Istore)
        {
            _Istore = Istore;
        }

        public IViewComponentResult Invoke()
        {
            return View(_Istore.GetMenuList(ViewBag.FuterLanguage));
        }
    }
}
