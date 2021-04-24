using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMenegment.StoreService.Helper
{
    public class FileObject
    {
        public int FileObjectId { get; set; }
        public string ObjectName { get; set; }
        public string ObjectAddres { get; set; }
        public bool IsMain { get; set; }
        public bool IsDelete { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
