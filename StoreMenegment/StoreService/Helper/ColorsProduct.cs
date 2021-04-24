using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMenegment.StoreService.Helper
{
    public class ColorsProduct
    {
        public int ProductColorId { get; set; }
        public string ProductColorName { get; set; }
        public bool IsDelete { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
