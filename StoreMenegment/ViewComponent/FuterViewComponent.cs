using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreMenegment.IStoreService;

namespace StoreMenegment.ViewComponents
{
    public class FuterViewComponent : ViewComponent
    {
        private IstoreManagmentService _Istore;

        public FuterViewComponent(IstoreManagmentService Istore)
        {
            _Istore = Istore;
        }


        public IViewComponentResult Invoke()
        {

            return View(_Istore.GetFuterMenuList(ViewBag.FuterLanguage));
        }
    }
}
