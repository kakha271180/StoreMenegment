using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreMenegment.Data;
using StoreMenegment.IStoreService;
using StoreMenegment.Models;
using StoreMenegment.StoreService.Helper;

namespace StoreMenegment.StoreService
{
    public class StoreManegmentSerice : IstoreManagmentService
    {
        ApplicationDbContext _application;

        public StoreManegmentSerice(ApplicationDbContext application)
        {
            _application = application;
        }

        public LanguagesList GetLanguage()
        {
            var LanguagesLists = _application.Languages.Select(l => new LanguagesList.Language
            {
                LanguageId = l.LanguageId,
                IsDelete = l.IsDelete,
                LanguageNume = l.LanguageName,
                RecordDate = l.RecordDate
            });


            return new LanguagesList { Languages = LanguagesLists };
        }

        public IEnumerable<Futer> GetFuterMenuList(int m)
        {
            var FuterList = _application.Futers.Where(i => i.IsDelete == false && i.LanguageId == m).Select(m =>
                               new Futer
                               {
                                   FuterId = m.FuterId,
                                   FuterName = m.FuterName,
                                   FuterParentId = m.FuterParentId,
                                   IsDelete = m.IsDelete,
                                   LanguageId = m.LanguageId,
                                   RecordDate = m.RecordDate
                               });


            return FuterList;
        }

        public IEnumerable<Menu> GetMenuList(int index)
        {
            var mm = _application.Menus.Where(p => p.IsDelete == false && p.LanguageId == 2).Select(j => new Menu
            {
                MenuId = j.MenuId,
                MenuName = j.MenuName,
                MenuParentId = j.MenuParentId,
                MenuNameEnglish = j.MenuName
            });
            var menuList = _application.Menus
                .Where(m => m.IsDelete == false && m.LanguageId == index)
                .Select(
                        s => new Menu
                        {
                            MenuId = s.MenuId,
                            MenuName = s.MenuName,
                            MenuParentId = s.MenuParentId,
                            LanguageId = s.LanguageId,
                            MenuNameEnglish = mm.SingleOrDefault(m => m.MenuParentId == s.MenuParentId).MenuNameEnglish
                        });

            return menuList;
        }

        public IEnumerable<string> GetColors(int Id)
        {
            var color = _application.ProductColors.Where(f => f.IsDelete == false).Select(g => new ColorsProduct
            {
                IsDelete = g.IsDelete,
                ProductColorId = g.ProductColorId,
                ProductColorName = g.ProductColorName,
                RecordDate = g.RecordDate
            }).ToList();

            var result = color.Where(m => m.ProductColorId == Id).Select(l => l.ProductColorName).ToList();

            return result;
        }

        public IQueryable<FileObject> GetPicture(int id)
        {
            var pictureFileObject = _application.ObjectFiles.Where(o => o.IsDelete == false && o.ObjectFileId == id).Select(m => new FileObject
            {
                IsDelete = m.IsDelete,
                FileObjectId = m.ObjectFileId,
                IsMain = m.IsMain,
                ObjectAddres = m.ObjectAddres,
                ObjectName = m.ObjectName,
                RecordDate = m.RecordDate
            });

            return pictureFileObject;
        }

        public IEnumerable<ProductSale> GetSaleNewProductList(int LanguageId)
        {
            IQueryable<ProductSale> productList;

            if (_application.Products.Any(k => k.SalesDiscount > 0))
            {
                productList = _application.Products
                    .Where(m => m.IsDelete == false && m.LanguageId == LanguageId && m.SalesDiscount > 0)
                    .Select(k => new ProductSale
                    {
                        ProductID = k.ProductID,
                        SalesDiscount = k.SalesDiscount,
                        ProductName = k.ProductName,
                        Quantity = k.Quantity,
                        RecordDate = k.RecordDate,
                        TotalPrice = k.TotalPrice,
                        Unit = k.Unit,
                        UnitPrice = k.UnitPrice,
                        Description = k.Description,

                        PictureAdresMain = GetPicture(k.ObjectFileId).SingleOrDefault(y => y.IsMain == true).ObjectAddres,
                        PictureAdres = GetPicture(k.ObjectFileId).Where(r => r.IsMain == false).Select(q => q.ObjectAddres).ToList(),
                        ProductColor = GetColors(k.ProductColorId).ToList()
                    });
            }
            else
            {
                productList = _application.Products
                    .Where(m => m.IsDelete == false && m.LanguageId == LanguageId && m.RecordDate.Month == DateTime.Now.Month)
                    .Select(k => new ProductSale
                    {
                        ProductID = k.ProductID,
                        SalesDiscount = k.SalesDiscount,
                        ProductName = k.ProductName,
                        Quantity = k.Quantity,
                        RecordDate = k.RecordDate,
                        TotalPrice = k.TotalPrice,
                        Unit = k.Unit,
                        UnitPrice = k.UnitPrice
                    });
            }

            return productList;
        }


    }
}
