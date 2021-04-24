using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreMenegment.StoreService.Helper;

namespace StoreMenegment.IStoreService
{
    public interface IstoreManagmentService
    {
        public LanguagesList GetLanguage();
        public IEnumerable<Futer> GetFuterMenuList(int m);
        public IEnumerable<Menu> GetMenuList(int index);
        public IEnumerable<ProductSale> GetSaleNewProductList(int LanguageId);
        public IEnumerable<string> GetColors(int index);
    }
}
