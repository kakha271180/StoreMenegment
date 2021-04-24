using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMenegment.StoreService.Helper
{
    public class LanguagesList
    {
        public int IndexId { get; set; }
        public IEnumerable<Language> Languages { get; set; }

        public class Language
        {
            public int LanguageId { get; set; }
            public string LanguageNume { get; set; }
            public bool IsDelete { get; set; }
            public DateTime RecordDate { get; set; }
        }
    }
}
