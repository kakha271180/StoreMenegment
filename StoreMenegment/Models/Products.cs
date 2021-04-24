using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMenegment.Models
{
    public class Products
    {
        [Display(Name = "რიგის ნომერი")]
        public int ProductID { get; set; }

        [Display(Name = "პროდუქტის დასახელება")]
        public string ProductName { get; set; }

        [Display(Name = "შტრიხკოდი")]
        public string BarCode { get; set; }

        [Display(Name = "რაოდენობა")]
        public int Quantity { get; set; }

        [Display(Name = "ერთეული")]
        public string Unit { get; set; }

        [Display(Name = "ერთეულის ფასი")]
        public float UnitPrice { get; set; }

        [Display(Name = "მთლიანი ღირებულება")]
        public float TotalPrice { get; set; }

        [Display(Name = "ფასდაკლება")]
        public float SalesDiscount { get; set; }

        [Display(Name = "ჩანაწერის თარიღი")]
        public DateTime RecordDate { get; set; }

        [Display(Name = "წაშლილი")]
        public bool IsDelete { get; set; }

        public string Description { get; set; }

        public int ProductColorId { get; set; }
        public ProductColors ProductColor { get; set; }

        public int ProductParentID { get; set; }
        public Products ProductParent { get; set; }

        public int LanguageId { get; set; }
        public Languages Language { get; set; }

        public int TechnicsId { get; set; }
        public Techniques Technics { get; set; }

        public int BrendiesId { get; set; }
        public Brands Brandies { get; set; }

        public int CategoryId { get; set; }
        public Categories Categories { get; set; }

        public int ObjectFileId { get; set; }
        public ObjectFiles ObjectFile { get; set; }

        public int ShopAdreshId { get; set; }
        public Address ShopAdres { get; set; }

    }

    public class ProductColors
    {
        public int ProductColorId { get; set; }
        public string ProductColorName { get; set; }
        public bool IsDelete { get; set; }
        public DateTime RecordDate { get; set; }
    }

    public class Categories
    {
        [Display(Name = "კატეგორიის როგის ნომერი")]
        public int CategoryId { get; set; }

        [Display(Name = "კატეგორიის დასახელება")]
        public string CategoryName { get; set; }

        [Display(Name = "წაშლილი")]
        public bool IsDelete { get; set; }

        [Display(Name = "ჩანაწერის თარიღი")]
        public DateTime RecordDate { get; set; }

        public int CategoryParentId { get; set; }
        public Categories CategoryParent { get; set; }

        public int ObjectFileId { get; set; }
        public ObjectFiles ObjectFile { get; set; }

        public int LanguageId { get; set; }
        public Languages Language { get; set; }
    }

    public class Techniques
    {
        [Display(Name = "რიგითი ნომერი")]
        public int TechnicsId { get; set; }

        [Display(Name = "ტექნიკის დასახელება")]
        public string TechnicsName { get; set; }

        [Display(Name = "წაშლილი")]
        public bool IsDelete { get; set; }

        [Display(Name = "ჩანაწერის თარიღი")]
        public DateTime RecordDate { get; set; }


        public int ObjectFileId { get; set; }
        public ObjectFiles ObjectFile { get; set; }

        public int TechnicParentId { get; set; }
        public Techniques TechnicParent { get; set; }

        public int LanguageId { get; set; }
        public Languages Language { get; set; }

    }

    public class Brands
    {
        [Display(Name = "რიგითი ნომერი")]
        public int BrandyId { get; set; }

        [Display(Name = "ბრენდის დასახელება")]
        public string BrandyName { get; set; }

        [Display(Name = "წაშლილი")]
        public bool IsDelete { get; set; }

        [Display(Name = "ჩანაწერის თარიღი")]
        public DateTime RecordDate { get; set; }


        public int ObjectFileId { get; set; }
        public ObjectFiles ObjectFile { get; set; }

        public int BrandyParentId { get; set; }
        public Brands BrandParent { get; set; }

        public int LanguageId { get; set; }
        public Languages Language { get; set; }

    }

    public class ObjectFiles
    {
        [Display(Name = "რიგითი ნომერი")]
        public int ObjectFileId { get; set; }

        [Display(Name = "ფაილის დასახელება")]
        public string ObjectName { get; set; }

        [Display(Name = "ფაილის მისამართი")]
        public string ObjectAddres { get; set; }

        [Display(Name = "მთავარი")]
        public bool IsMain { get; set; }

        [Display(Name = "წაშლილი")]
        public bool IsDelete { get; set; }

        [Display(Name = "ჩაწერის თარიღი")]
        public DateTime RecordDate { get; set; }
    }

    public class SendProducts
    {

        [Display(Name = "რიგის ნომერი")]
        public int SendProductID { get; set; }

        [Display(Name = "რაოდენობა")]
        public int Quantity { get; set; }

        [Display(Name = "ერთეული")]
        public string Unit { get; set; }

        [Display(Name = "ერთეულის ფასი")]
        public float UnitPrice { get; set; }

        [Display(Name = "მთლიანი ღირებულება")]
        public float TotalPrice { get; set; }

        public DateTime SendDate { get; set; }

        public DateTime ReceptionistDate { get; set; }

        public bool SupplyConfirming { get; set; }

        public DateTime SupplyConfirmingDate { get; set; }

        public bool SurrenderConfirming { get; set; }

        public DateTime SurrenderDate { get; set; }
        public DateTime RecordDate { get; set; }

        public bool IsDelete { get; set; }

        public int ProductParentId { get; set; }
        public Products Product { get; set; }

        public int SendShopAdresId { get; set; }
        public Address SendShopAdres { get; set; }

        public int ReceptionistShopAdresId { get; set; }
        public Address ReceptionistAdres { get; set; }

        public int SendEmployeeId { get; set; }
        public Employees SendEmploee { get; set; }

        public int ReceptionistEmployeeId { get; set; }
        public Employees ReceptionistEmploee { get; set; }

        public int FileObjectId { get; set; }
        public ObjectFiles ObjectFile { get; set; }
    }

    public class Address
    {
        [Display(Name = "რიგის ნომერი")]
        public int AdresId { get; set; }

        [Display(Name = "ქუჩის დასახელება")]
        public string ShopAdresStritName { get; set; }

        [Display(Name = "ჩანაწერის თარიღი")]
        public DateTime RecordDate { get; set; }

        [Display(Name = "წაშლილია")]
        public bool IsDelete { get; set; }

        public int AdresParentId { get; set; }
        public Address AddresParent { get; set; }

        public int CityId { get; set; }
        public Cities City { get; set; }

        public int ObjectFileId { get; set; }
        public ObjectFiles ObjectFile { get; set; }

        public int LanguageId { get; set; }
        public Languages Language { get; set; }
    }

    public class Cities
    {
        [Display(Name = "რიგის ნომერი")]
        public int CityId { get; set; }

        [Display(Name = "ქალაქის დასახელება")]
        public string CityName { get; set; }

        [Display(Name = "ჩანაწერის თარიღი")]
        public DateTime RecordDate { get; set; }

        [Display(Name = "წაშლილია")]
        public bool IsDelete { get; set; }

        public int CityParentId { get; set; }
        public Cities CityParent { get; set; }

        public int LanguageId { get; set; }
        public Languages Language { get; set; }

    }

    public class ProductsSold
    {
        public int ProductSoldId { get; set; }

        [Display(Name = "რაოდენობა")]
        public int Quantity { get; set; }

        [Display(Name = "ერთეული")]
        public string Unit { get; set; }

        [Display(Name = "ერთეულის ფასი")]
        public float UnitPrice { get; set; }

        [Display(Name = "მთლიანი ღირებულება")]
        public float TotalPrice { get; set; }

        public DateTime DateOfSale { get; set; }

        public float InstallmentAmount { get; set; }

        public float Cash { get; set; }

        public float TerminalAmount { get; set; }

        public bool IsDelete { get; set; }

        public DateTime RecordDate { get; set; }


        public int ObjectFileId { get; set; }
        public ObjectFiles ObjectFile { get; set; }

        public int MethodOfPaymentParentId { get; set; }
        public PaymentMethods MethodOfPayment { get; set; }

        public int EmployeeId { get; set; }
        public Employees Emploee { get; set; }

        public int ProductParentId { get; set; }
        public Products Product { get; set; }

    }

    public class PaymentMethods
    {
        public int MethodOfPaymentId { get; set; }
        public string MethodOfPaymentName { get; set; }
        public DateTime RecordDate { get; set; }
        public bool IsDelete { get; set; }

        public int MethodOfPaymentParentId { get; set; }
        public PaymentMethods MethodOfPaymentParent { get; set; }

        public int LanguageId { get; set; }
        public Languages Language { get; set; }
    }

    public class Employees
    {
        public int EmployeeId { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Phone1 { get; set; }
        public string ElPosta { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfReceipt { get; set; }
        public DateTime DateOfRelease { get; set; }
        public DateTime RecordDate { get; set; }


        public int PosishenId { get; set; }
        public Positions Posishen { get; set; }

        public int BrenchAddresId { get; set; }
        public Address BrenchAddres { get; set; }

        public int LanguageId { get; set; }
        public Languages Language { get; set; }

        public int EmployeeParentId { get; set; }
        public Employees EmployParent { get; set; }

    }

    public class Positions
    {
        public int PosishenId { get; set; }
        public string PosishenName { get; set; }
        public float Salary { get; set; }
        public bool IsDelete { get; set; }
        public DateTime RecordDate { get; set; }


        public int DepartmentId { get; set; }
        public Departments Departments { get; set; }

        public int PosishenTypeId { get; set; }
        public PositionTypes PosishenTypes { get; set; }

        public int PosishenParentId { get; set; }
        public Positions PositionParent { get; set; }

        public int LanguageId { get; set; }
        public Languages Languages { get; set; }

    }

    public class Departments
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool IsDelete { get; set; }
        public DateTime RecordDate { get; set; }

        public int DepartmentParentId { get; set; }
        public Departments DepartmentParent { get; set; }

        public int LanguageId { get; set; }
        public Languages Languages { get; set; }
    }

    public class PositionTypes
    {
        public int PositionTypeId { get; set; }

        public string PositionTypeName { get; set; }

        public DateTime RecordDate { get; set; }

        public bool IsDelete { get; set; }


        public int PositionTypeParentstId { get; set; }
        public PositionTypes PositionTypeParent { get; set; }

        public int LanguageId { get; set; }
        public Languages Languages { get; set; }
    }

    public class Orders
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public float UnitPrice { get; set; }
        public float TotalPrice { get; set; }
        public bool DeliveryService { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime RecordDate { get; set; }
        public bool IsDelete { get; set; }
        public bool ConfirmationOfSupply { get; set; }
        public DateTime ConfirmationOfSupplyDate { get; set; }/*GetDate()*/
        public bool ConfirmationOfDelivery { get; set; }
        public DateTime ConfirmationOfDeliveryDate { get; set; }/*GetDate()*/


        public int ProductParentID { get; set; }
        public Products Product { get; set; }

        public int MyUserId { get; set; }
        public MyUsers MyUsers { get; set; }

        public int OrderParentId { get; set; }
        public Orders OrderParent { get; set; }

        public int LanguageId { get; set; }
        public Languages Languages { get; set; }

        public int SupplyId { get; set; }
        public Supplies Supplys { get; set; }
    }

    public class Supplies
    {
        public int SupplyId { get; set; }

        public DateTime RecordDate { get; set; }

        public bool IsDelete { get; set; }

        public bool ConfirmationOfPerformance { get; set; }

        public DateTime ConfirmationOfPerformanceDate { get; set; }

        public int EmployeeGroupId { get; set; }
        public EmployeeGroups EmployeeGroups { get; set; }

        public int LanguageId { get; set; }
        public Languages Languages { get; set; }

        public int SupplyParentId { get; set; }
        public Supplies SupplyParent { get; set; }
    }

    public class EmployeeGroups
    {
        public int EmployeeGroupId { get; set; }

        public string EmployeeGroupNumber { get; set; }

        public DateTime RecordDate { get; set; }

        public bool IsDelete { get; set; }

        public int LanguageId { get; set; }
        public Languages Languages { get; set; }

        public int EmployeeGroupParentId { get; set; }
        public EmployeeGroups EmployeeGroupParent { get; set; }

        public int EmployeeId { get; set; }
        public Employees Employee { get; set; }
    }

    public class Menus
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public DateTime RecordDate { get; set; }
        public bool IsDelete { get; set; }


        public int MenuParentId { get; set; }
        public Menus MenuParent { get; set; }

        public int LanguageId { get; set; }
        public Languages Languages { get; set; }
    }

    public class Futers
    {
        public int FuterId { get; set; }
        public string FuterName { get; set; }
        public bool IsDelete { get; set; }
        public DateTime RecordDate { get; set; }

        public int FuterParentId { get; set; }
        public Futers FuterParent { get; set; }

        public int LanguageId { get; set; }
        public Languages Language { get; set; }
    }

    public class Languages
    {
        [Display(Name = "რიგითი ნომერი")]
        public int LanguageId { get; set; }

        [Display(Name = "ენის დასახელება")]
        public string LanguageName { get; set; }

        [Display(Name = "წაშლილია")]
        public bool IsDelete { get; set; }

        [Display(Name = "ჩანაწერის თარიღი")]
        public DateTime RecordDate { get; set; }

    }

    public class MyUsers
    {

        public int MyUserId { get; set; }
        public string AspNetUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
        public string Phone { get; set; }
        public string ElPosta { get; set; }
        public string UserName { get; set; }
        public string Pasword { get; set; }
        public DateTime RecordDate { get; set; }
        public string Adres { get; set; }
        public bool IsDelete { get; set; }
    }


    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "მეილი")]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "პაროლი")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "გაიმეორე პაროლი")]
        [Compare("Password", ErrorMessage = "პაროლი და დამადასტურებელი პაროლი არ ემთხვევა ერთმანეთს.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "მაილი")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "პაროლი")]
        public string Password { get; set; }



        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
