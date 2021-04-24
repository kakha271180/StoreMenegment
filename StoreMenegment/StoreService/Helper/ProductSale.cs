using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMenegment.StoreService.Helper
{
    public class ProductSale
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public float UnitPrice { get; set; }
        public float TotalPrice { get; set; }
        public float SalesDiscount { get; set; }
        public DateTime RecordDate { get; set; }
        public string Description { get; set; }
        public List<string> ProductColor { get; set; }
        public string PictureAdresMain { get; set; }
        public List<string> PictureAdres { get; set; }
        //public string PictureAdres2 { get; set; }
        //public string PictureAdres3 { get; set; }
    }
}
