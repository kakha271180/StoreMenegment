using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMenegment.StoreService.Helper
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }

        public int MenuParentId { get; set; }
        public int LanguageId { get; set; }
        public string MenuNameEnglish { get; set; }
    }
}
