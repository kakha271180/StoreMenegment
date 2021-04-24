using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMenegment.StoreService.Helper
{
    public class Futer
    {
        public int FuterId { get; set; }
        public string FuterName { get; set; }
        public bool IsDelete { get; set; }
        public DateTime RecordDate { get; set; }
        public int FuterParentId { get; set; }
        public int LanguageId { get; set; }
    }
}
