using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreMenegment.Models;

namespace StoreMenegment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
            _options = options;
        }


        public DbSet<Languages> Languages { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Techniques> Technics { get; set; }
        public DbSet<Brands> Brandies { get; set; }
        public DbSet<ObjectFiles> ObjectFiles { get; set; }
        public DbSet<Address> Adres { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<SendProducts> SendProductss { get; set; }
        public DbSet<ProductsSold> ProductSolds { get; set; }
        public DbSet<PaymentMethods> MethodOfPayments { get; set; }
        public DbSet<MyUsers> MyUsers { get; set; }
        public DbSet<Employees> Employeess { get; set; }
        public DbSet<Positions> Posishens { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<PositionTypes> PosishenTypes { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Supplies> Supplies { get; set; }
        public DbSet<EmployeeGroups> EmployeesGroups { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Futers> Futers { get; set; }
        public DbSet<ProductColors> ProductColors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Languages>().HasKey(l => l.LanguageId);
            modelBuilder.Entity<Languages>().Property(l => l.LanguageName).IsRequired().HasColumnType("Nvarchar(100)");
            modelBuilder.Entity<Languages>().Property(l => l.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Languages>().Property(l => l.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");


            modelBuilder.Entity<Products>().HasKey(p => p.ProductID);
            modelBuilder.Entity<Products>().Property(p => p.ProductName).IsRequired().HasColumnType("nvarchar(350)");
            modelBuilder.Entity<Products>().Property(p => p.BarCode).IsRequired().HasColumnType("nvarchar(35)");
            modelBuilder.Entity<Products>().Property(p => p.Quantity).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Products>().Property(p => p.Unit).IsRequired().HasColumnType("nvarchar(20)");
            modelBuilder.Entity<Products>().Property(p => p.UnitPrice).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<Products>().Property(p => p.TotalPrice).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<Products>().Property(p => p.SalesDiscount).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<Products>().Property(p => p.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Products>().Property(p => p.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Products>().Property(p => p.Description).HasColumnType("nvarchar(max)");
            modelBuilder.Entity<ProductColors>().HasMany<Products>().WithOne(p => p.ProductColor).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ProductColorId").HasConstraintName("FK_ProductColorId");
            modelBuilder.Entity<Products>().HasMany<Products>().WithOne(p => p.ProductParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ProductParentID").HasConstraintName("FK_ProductParentID");
            modelBuilder.Entity<Languages>().HasMany<Products>().WithOne(p => p.Language).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");
            modelBuilder.Entity<Techniques>().HasMany<Products>().WithOne(p => p.Technics).OnDelete(DeleteBehavior.Cascade).HasForeignKey("TechnicsId").HasConstraintName("FK_TechnicsId");
            modelBuilder.Entity<Brands>().HasMany<Products>().WithOne(p => p.Brandies).OnDelete(DeleteBehavior.Cascade).HasForeignKey("BrendiesId").HasConstraintName("FK_BrendiesId");
            modelBuilder.Entity<Categories>().HasMany<Products>().WithOne(p => p.Categories).OnDelete(DeleteBehavior.Cascade).HasForeignKey("CategoryId").HasConstraintName("FK_CategoryId");
            modelBuilder.Entity<ObjectFiles>().HasMany<Products>().WithOne(p => p.ObjectFile).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ObjectFileId").HasConstraintName("FK_ObjectFileId");
            modelBuilder.Entity<Address>().HasMany<Products>().WithOne(p => p.ShopAdres).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ShopAdreshId").HasConstraintName("FK_ShopAdreshId");


            modelBuilder.Entity<ProductColors>().HasKey(p => p.ProductColorId);
            modelBuilder.Entity<ProductColors>().Property(p => p.ProductColorName).IsRequired().HasColumnType("nvarchar(150)");
            modelBuilder.Entity<ProductColors>().Property(p => p.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<ProductColors>().Property(p => p.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<Categories>().HasKey(c => c.CategoryId);
            modelBuilder.Entity<Categories>().Property(c => c.CategoryName).IsRequired().HasColumnType("nvarchar(300)");
            modelBuilder.Entity<Categories>().Property(c => c.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Categories>().Property(c => c.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Categories>().HasMany<Categories>().WithOne(c => c.CategoryParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("CategoryParentId").HasConstraintName("FK_CategoryParentId");
            modelBuilder.Entity<ObjectFiles>().HasMany<Categories>().WithOne(c => c.ObjectFile).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ObjectFileId")/*.HasPrincipalKey("ObjectFileId")*/.HasConstraintName("FK_ObjectFileId");
            modelBuilder.Entity<Languages>().HasMany<Categories>().WithOne(c => c.Language).OnDelete(DeleteBehavior.Cascade).HasForeignKey("LanguageId").HasConstraintName("FK_LanguageId");


            modelBuilder.Entity<Techniques>().HasKey(t => t.TechnicsId);
            modelBuilder.Entity<Techniques>().Property(t => t.TechnicsName).IsRequired().HasColumnType("nvarchar(300)");
            modelBuilder.Entity<Techniques>().Property(t => t.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Techniques>().Property(t => t.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Techniques>().HasMany<Techniques>().WithOne(t => t.TechnicParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("TechnicParentId").HasConstraintName("FK_TechnicParentId");
            modelBuilder.Entity<ObjectFiles>().HasMany<Techniques>().WithOne(t => t.ObjectFile).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ObjectFileId").HasConstraintName("FK_ObjectFileId");
            modelBuilder.Entity<Languages>().HasMany<Techniques>().WithOne(t => t.Language).OnDelete(DeleteBehavior.Cascade).HasForeignKey("LanguageId").HasConstraintName("FK_LanguageId");


            modelBuilder.Entity<Brands>().HasKey(b => b.BrandyId);
            modelBuilder.Entity<Brands>().Property(b => b.BrandyName).IsRequired().HasColumnType("nvarchar(100)");
            modelBuilder.Entity<Brands>().Property(b => b.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Brands>().Property(b => b.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Brands>().HasMany<Brands>().WithOne(b => b.BrandParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("BrandyParentId").HasConstraintName("FK_BrandyParentId");
            modelBuilder.Entity<ObjectFiles>().HasMany<Brands>().WithOne(b => b.ObjectFile).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ObjectFileId").HasConstraintName("FK_ObjectfileId");
            modelBuilder.Entity<Languages>().HasMany<Brands>().WithOne(b => b.Language).OnDelete(DeleteBehavior.Cascade).HasForeignKey("LanguageId").HasConstraintName("FK_LanguageId");

            modelBuilder.Entity<ObjectFiles>().HasKey(o => o.ObjectFileId);
            modelBuilder.Entity<ObjectFiles>().Property(o => o.ObjectName).IsRequired().HasColumnType("nvarchar(300)");
            modelBuilder.Entity<ObjectFiles>().Property(o => o.ObjectAddres).IsRequired().HasColumnType("nvarchar(max)");
            modelBuilder.Entity<ObjectFiles>().Property(o => o.IsMain).HasColumnType("bit").IsRequired().HasDefaultValueSql("0");
            modelBuilder.Entity<ObjectFiles>().Property(o => o.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<ObjectFiles>().Property(o => o.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");


            modelBuilder.Entity<Address>().HasKey(a => a.AdresId);
            modelBuilder.Entity<Address>().Property(a => a.ShopAdresStritName).IsRequired().HasColumnType("nvarchar(500)");
            modelBuilder.Entity<Address>().Property(a => a.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Address>().Property(a => a.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Address>().HasMany<Address>().WithOne(a => a.AddresParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("AdresParentId").HasConstraintName("FK_AdresParentId");
            modelBuilder.Entity<Cities>().HasMany<Address>().WithOne(a => a.City).OnDelete(DeleteBehavior.Cascade).HasForeignKey("CityId").HasConstraintName("FK_CityId");
            modelBuilder.Entity<ObjectFiles>().HasMany<Address>().WithOne(a => a.ObjectFile).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ObjectFileId").HasConstraintName("FK_ObjectFileId");
            modelBuilder.Entity<Languages>().HasMany<Address>().WithOne(a => a.Language).OnDelete(DeleteBehavior.Cascade).HasForeignKey("LanguageId").HasConstraintName("FK_LanguageId");


            modelBuilder.Entity<Cities>().HasKey(c => c.CityId);
            modelBuilder.Entity<Cities>().Property(c => c.CityName).IsRequired().HasColumnType("nvarchar(150)");
            modelBuilder.Entity<Cities>().Property(c => c.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Cities>().Property(c => c.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Cities>().HasMany<Cities>().WithOne(c => c.CityParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("CityParentId").HasConstraintName("FK_CityParentId");
            modelBuilder.Entity<Languages>().HasMany<Cities>().WithOne(c => c.Language).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");


            modelBuilder.Entity<SendProducts>().HasKey(s => s.SendProductID);
            modelBuilder.Entity<SendProducts>().Property(s => s.Quantity).IsRequired().HasColumnType("int");
            modelBuilder.Entity<SendProducts>().Property(s => s.Unit).IsRequired().HasColumnType("nvarchar(20)");
            modelBuilder.Entity<SendProducts>().Property(s => s.UnitPrice).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<SendProducts>().Property(s => s.TotalPrice).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<SendProducts>().Property(s => s.SendDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<SendProducts>().Property(s => s.ReceptionistDate).HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<SendProducts>().Property(s => s.SupplyConfirming).HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<SendProducts>().Property(s => s.SupplyConfirmingDate).HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<SendProducts>().Property(s => s.SurrenderConfirming).HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<SendProducts>().Property(s => s.SurrenderDate).HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<SendProducts>().Property(s => s.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<SendProducts>().Property(s => s.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Address>().HasMany<SendProducts>().WithOne(s => s.SendShopAdres).OnDelete(DeleteBehavior.Cascade).HasForeignKey("SendShopAdresId").HasConstraintName("FK_SendShopAdresId");
            modelBuilder.Entity<Address>().HasMany<SendProducts>().WithOne(s => s.ReceptionistAdres).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ReceptionistShopAdresId").HasConstraintName("FK_ReceptionistShopAdresId");
            modelBuilder.Entity<Employees>().HasMany<SendProducts>().WithOne(s => s.SendEmploee).OnDelete(DeleteBehavior.Cascade).HasForeignKey("SendEmployeesId").HasConstraintName("FK_SendEmployeesId");
            modelBuilder.Entity<Employees>().HasMany<SendProducts>().WithOne(s => s.ReceptionistEmploee).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ReceptionistEmployeesId").HasConstraintName("FK_ReceptionistEmployeesId");
            modelBuilder.Entity<ObjectFiles>().HasMany<SendProducts>().WithOne(s => s.ObjectFile).OnDelete(DeleteBehavior.Cascade).HasForeignKey("FileObjectId").HasConstraintName("FK_FileObjectId");
            modelBuilder.Entity<Products>().HasMany<SendProducts>().WithOne(s => s.Product).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ProductParentId").HasConstraintName("FK_ProductParentId");


            modelBuilder.Entity<ProductsSold>().HasKey(p => p.ProductSoldId);
            modelBuilder.Entity<ProductsSold>().Property(p => p.Quantity).IsRequired().HasColumnType("int");
            modelBuilder.Entity<ProductsSold>().Property(p => p.Unit).IsRequired().HasColumnType("nvarchar(20)");
            modelBuilder.Entity<ProductsSold>().Property(p => p.UnitPrice).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<ProductsSold>().Property(p => p.TotalPrice).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<ProductsSold>().Property(p => p.DateOfSale).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<ProductsSold>().Property(p => p.InstallmentAmount).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<ProductsSold>().Property(p => p.Cash).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<ProductsSold>().Property(p => p.TerminalAmount).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<ProductsSold>().Property(p => p.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<ProductsSold>().Property(p => p.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Products>().HasMany<ProductsSold>().WithOne(p => p.Product).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ProductParentId").HasConstraintName("FK_ProductParentId");
            modelBuilder.Entity<ObjectFiles>().HasMany<ProductsSold>().WithOne(p => p.ObjectFile).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ObjectFileId").HasConstraintName("FK_ObjectFileId");
            modelBuilder.Entity<PaymentMethods>().HasMany<ProductsSold>().WithOne(p => p.MethodOfPayment).OnDelete(DeleteBehavior.Cascade).HasForeignKey("MethodOfPaymentParentId").HasConstraintName("FK_MethodOfPaymentParentId");
            modelBuilder.Entity<Employees>().HasMany<ProductsSold>().WithOne(p => p.Emploee).OnDelete(DeleteBehavior.Cascade).HasForeignKey("EmployeesId").HasConstraintName("FK_EmployeesId");


            modelBuilder.Entity<PaymentMethods>().HasKey(m => m.MethodOfPaymentId);
            modelBuilder.Entity<PaymentMethods>().Property(m => m.MethodOfPaymentName).IsRequired().HasColumnType("nvarchar(150)");
            modelBuilder.Entity<PaymentMethods>().Property(m => m.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<PaymentMethods>().Property(m => m.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<PaymentMethods>().HasMany<PaymentMethods>().WithOne(m => m.MethodOfPaymentParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("MethodOfPaymentParentId").HasConstraintName("FK_MethodOfPaymentParentId");
            modelBuilder.Entity<Languages>().HasMany<PaymentMethods>().WithOne(m => m.Language).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");


            modelBuilder.Entity<MyUsers>().HasKey(u => u.MyUserId);
            modelBuilder.Entity<MyUsers>().Property(u => u.AspNetUserId).IsRequired().HasColumnType("nvarchar(150)");
            modelBuilder.Entity<MyUsers>().Property(u => u.FirstName).IsRequired().HasColumnType("nvarchar(75)");
            modelBuilder.Entity<MyUsers>().Property(u => u.LastName).IsRequired().HasColumnType("nvarchar(150)");
            modelBuilder.Entity<MyUsers>().Property(u => u.PersonalNumber).IsRequired().HasColumnType("nvarchar(15)");
            modelBuilder.Entity<MyUsers>().Property(u => u.Phone).IsRequired().HasColumnType("nvarchar(15)");
            modelBuilder.Entity<MyUsers>().Property(u => u.ElPosta).IsRequired().HasColumnType("nvarchar(150)");
            modelBuilder.Entity<MyUsers>().Property(u => u.UserName).IsRequired().HasColumnType("nvarchar(25)");
            modelBuilder.Entity<MyUsers>().Property(u => u.Pasword).IsRequired().HasColumnType("nvarchar(15)");
            modelBuilder.Entity<MyUsers>().Property(u => u.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<MyUsers>().Property(u => u.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<MyUsers>().Property(u => u.Adres).IsRequired().HasColumnType("nvarchar(max)");


            modelBuilder.Entity<Employees>().HasKey(e => e.EmployeeId);
            modelBuilder.Entity<Employees>().Property(e => e.FirsName).IsRequired().HasColumnType("nvarchar(50)");
            modelBuilder.Entity<Employees>().Property(e => e.LastName).IsRequired().HasColumnType("nvarchar(100)");
            modelBuilder.Entity<Employees>().Property(e => e.PersonalNumber).IsRequired().HasColumnType("nvarchar(15)");
            modelBuilder.Entity<Employees>().Property(e => e.BirthDate).IsRequired().HasColumnType("datetime2(7)");
            modelBuilder.Entity<Employees>().Property(e => e.Phone).IsRequired().HasColumnType("nvarchar(20)");
            modelBuilder.Entity<Employees>().Property(e => e.Phone1).IsRequired().HasColumnType("nvarchar(20)");
            modelBuilder.Entity<Employees>().Property(e => e.ElPosta).IsRequired().HasColumnType("nvarchar(90)");
            modelBuilder.Entity<Employees>().Property(e => e.UserName).IsRequired().HasColumnType("nvarchar(25)");
            modelBuilder.Entity<Employees>().Property(e => e.Password).IsRequired().HasColumnType("nvarchar(15)");
            modelBuilder.Entity<Employees>().Property(e => e.DateOfReceipt).HasColumnType("datetime2(7)");
            modelBuilder.Entity<Employees>().Property(e => e.DateOfRelease).HasColumnType("datetime2(7)");
            modelBuilder.Entity<Employees>().Property(e => e.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Positions>().HasMany<Employees>().WithOne(e => e.Posishen).OnDelete(DeleteBehavior.Cascade).HasForeignKey("PosishenId").HasConstraintName("FK_PosishenId");
            modelBuilder.Entity<Address>().HasMany<Employees>().WithOne(e => e.BrenchAddres).OnDelete(DeleteBehavior.Cascade).HasForeignKey("BrenchAddressesId").HasConstraintName("FK_BrenchAddressesId");
            modelBuilder.Entity<Languages>().HasMany<Employees>().WithOne(e => e.Language).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");
            modelBuilder.Entity<Employees>().HasMany<Employees>().WithOne(e => e.EmployParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("EmployeesParentId").HasConstraintName("FK_EmployeesParentId");


            modelBuilder.Entity<Positions>().HasKey(p => p.PosishenId);
            modelBuilder.Entity<Positions>().Property(p => p.PosishenName).IsRequired().HasColumnType("nvarchar(250)");
            modelBuilder.Entity<Positions>().Property(p => p.Salary).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<Positions>().Property(p => p.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Positions>().Property(p => p.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Departments>().HasMany<Positions>().WithOne(p => p.Departments).OnDelete(DeleteBehavior.Cascade).HasForeignKey("DepartmentId").HasConstraintName("FK_DepartmentId");
            modelBuilder.Entity<PositionTypes>().HasMany<Positions>().WithOne(p => p.PosishenTypes).OnDelete(DeleteBehavior.Cascade).HasForeignKey("PosishenTypeId").HasConstraintName("FK_PosishenTypeId");
            modelBuilder.Entity<Languages>().HasMany<Positions>().WithOne(p => p.Languages).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");
            modelBuilder.Entity<Positions>().HasMany<Positions>().WithOne(p => p.PositionParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("PosishenParentId").HasConstraintName("FK_PosishenParentId");


            modelBuilder.Entity<Departments>().HasKey(d => d.DepartmentId);
            modelBuilder.Entity<Departments>().Property(d => d.DepartmentName).IsRequired().HasColumnType("nvarchar(250)");
            modelBuilder.Entity<Departments>().Property(d => d.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Departments>().Property(d => d.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Departments>().HasMany<Departments>().WithOne(d => d.DepartmentParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("DepartmentParentId").HasConstraintName("FK_DepartmentParentId");
            modelBuilder.Entity<Languages>().HasMany<Departments>().WithOne(d => d.Languages).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");


            modelBuilder.Entity<PositionTypes>().HasKey(p => p.PositionTypeId);
            modelBuilder.Entity<PositionTypes>().Property(p => p.PositionTypeName).IsRequired().HasColumnType("nvarchar(250)");
            modelBuilder.Entity<PositionTypes>().Property(p => p.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<PositionTypes>().Property(p => p.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<PositionTypes>().HasMany<PositionTypes>().WithOne(p => p.PositionTypeParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("PosishenTypeParentstId").HasConstraintName("FK_PosishenTypeParentstId");
            modelBuilder.Entity<Languages>().HasMany<PositionTypes>().WithOne(p => p.Languages).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");


            modelBuilder.Entity<Orders>().HasKey(o => o.OrderId);
            modelBuilder.Entity<Orders>().Property(o => o.Quantity).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Orders>().Property(o => o.Unit).IsRequired().HasColumnType("nvarchar(20)");
            modelBuilder.Entity<Orders>().Property(o => o.UnitPrice).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<Orders>().Property(o => o.TotalPrice).IsRequired().HasColumnType("decimal(5,2)");
            modelBuilder.Entity<Orders>().Property(o => o.DeliveryService).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Orders>().Property(o => o.DeliveryAddress).IsRequired().HasColumnType("nvarchar(max)");
            modelBuilder.Entity<Orders>().Property(o => o.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Orders>().Property(o => o.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Orders>().Property(o => o.ConfirmationOfSupply).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Orders>().Property(o => o.ConfirmationOfSupplyDate).HasColumnType("datetime2(7)");
            modelBuilder.Entity<Orders>().Property(o => o.ConfirmationOfDelivery).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Orders>().Property(o => o.ConfirmationOfDeliveryDate).HasColumnType("datetime2(7)");
            modelBuilder.Entity<Products>().HasMany<Orders>().WithOne(o => o.Product).OnDelete(DeleteBehavior.Cascade).HasForeignKey("ProductParentID").HasConstraintName("FK_ProductParentID");
            modelBuilder.Entity<MyUsers>().HasMany<Orders>().WithOne(o => o.MyUsers).OnDelete(DeleteBehavior.Cascade).HasForeignKey("MyUserId").HasConstraintName("FK_MyUserId");
            modelBuilder.Entity<Languages>().HasMany<Orders>().WithOne(o => o.Languages).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");
            modelBuilder.Entity<Supplies>().HasMany<Orders>().WithOne(o => o.Supplys).OnDelete(DeleteBehavior.Cascade).HasForeignKey("SupplyId").HasConstraintName("FK_SupplyId");
            modelBuilder.Entity<Orders>().HasMany<Orders>().WithOne(o => o.OrderParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("OrderParentId").HasConstraintName("FK_OrderParentId");

            modelBuilder.Entity<Supplies>().HasKey(s => s.SupplyId);
            modelBuilder.Entity<Supplies>().Property(s => s.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Supplies>().Property(s => s.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Supplies>().Property(s => s.ConfirmationOfPerformance).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Supplies>().Property(s => s.ConfirmationOfPerformanceDate).HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<EmployeeGroups>().HasMany<Supplies>().WithOne(s => s.EmployeeGroups).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m=>m.EmployeeGroupId).HasConstraintName("FK_EmployeesGroupId");
            modelBuilder.Entity<Languages>().HasMany<Supplies>().WithOne(s => s.Languages).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");
            modelBuilder.Entity<Supplies>().HasMany<Supplies>().WithOne(e => e.SupplyParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("SupplyParentId").HasConstraintName("FK_SupplyParentId");

            modelBuilder.Entity<EmployeeGroups>().HasKey(e => e.EmployeeGroupId);
            modelBuilder.Entity<EmployeeGroups>().Property(e => e.EmployeeGroupNumber).IsRequired().HasColumnType("nvarchar(8)");
            modelBuilder.Entity<EmployeeGroups>().Property(o => o.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<EmployeeGroups>().Property(o => o.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Employees>().HasMany<EmployeeGroups>().WithOne(e => e.Employee).OnDelete(DeleteBehavior.Cascade).HasForeignKey("EmployeesId").HasConstraintName("FK_EmployeesId");
            modelBuilder.Entity<Languages>().HasMany<EmployeeGroups>().WithOne(e => e.Languages).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");
            modelBuilder.Entity<EmployeeGroups>().HasMany<EmployeeGroups>().WithOne(e => e.EmployeeGroupParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("EmployeeGroupParentId").HasConstraintName("FK_EmployeeGroupParentId");

            modelBuilder.Entity<Menus>().HasKey(m => m.MenuId);
            modelBuilder.Entity<Menus>().Property(m => m.MenuName).IsRequired().HasColumnType("nvarchar(250)");
            modelBuilder.Entity<Menus>().Property(m => m.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Menus>().Property(m => m.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Menus>().HasMany<Menus>().WithOne(m => m.MenuParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("MenuParentId").HasConstraintName("FK_MenuParentId");
            modelBuilder.Entity<Languages>().HasMany<Menus>().WithOne(m => m.Languages).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");

            modelBuilder.Entity<Futers>().HasKey(f => f.FuterId);
            modelBuilder.Entity<Futers>().Property(f => f.FuterName).HasColumnType("nvarchar(250)");
            modelBuilder.Entity<Futers>().Property(f => f.IsDelete).IsRequired().HasColumnType("bit").HasDefaultValueSql("0");
            modelBuilder.Entity<Futers>().Property(f => f.RecordDate).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Futers>().HasMany<Futers>().WithOne(m => m.FuterParent).OnDelete(DeleteBehavior.Cascade).HasForeignKey("FuterParentId").HasConstraintName("FK_FuterParentId");
            modelBuilder.Entity<Languages>().HasMany<Futers>().WithOne(m => m.Language).OnDelete(DeleteBehavior.Cascade).HasForeignKey(m => m.LanguageId).HasConstraintName("FK_LanguageId");


            modelBuilder.Entity<Languages>().HasData(
                                                    new Languages() { LanguageId = 1, LanguageName = "ქართული" },
                                                    new Languages() { LanguageId = 2, LanguageName = "English" },
                                                    new Languages() { LanguageId = 3, LanguageName = "русский" }
                                                    );

            modelBuilder.Entity<Futers>().HasData(
                                                    new Futers() { FuterId = 1, FuterName = "სამუშაო საათები", FuterParentId = 1, LanguageId = 1 },
                                                    new Futers() { FuterId = 2, FuterName = "ონლაინ მაღაზია: 24/7", FuterParentId = 2, LanguageId = 1 },
                                                    new Futers() { FuterId = 3, FuterName = "ორშაბათი-პარასკევი: 09:00-20:00", FuterParentId = 3, LanguageId = 1 },
                                                    new Futers() { FuterId = 4, FuterName = "შაბათი-კვირა: 09:00-18:00", FuterParentId = 4, LanguageId = 1 },
                                                    new Futers() { FuterId = 5, FuterName = "კონტაქტი", FuterParentId = 5, LanguageId = 1 },
                                                    new Futers() { FuterId = 6, FuterName = "მობილური: 599985226", FuterParentId = 6, LanguageId = 1 },
                                                    new Futers() { FuterId = 7, FuterName = "ქალაქი: 0995322706389", FuterParentId = 7, LanguageId = 1 },
                                                    new Futers() { FuterId = 8, FuterName = "მისამართი: ბერი გაბრიელ სალოსის 7-ე შეს. 10-ე კორ.", FuterParentId = 8, LanguageId = 1 },

                                                    new Futers() { FuterId = 9, FuterName = "working hours", FuterParentId = 1, LanguageId = 2 },
                                                    new Futers() { FuterId = 10, FuterName = "online shop: 24/7", FuterParentId = 2, LanguageId = 2 },
                                                    new Futers() { FuterId = 11, FuterName = "Monday-Friday: 09:00-20:00", FuterParentId = 3, LanguageId = 2 },
                                                    new Futers() { FuterId = 12, FuterName = "weekend: 09:00-18:00", FuterParentId = 4, LanguageId = 2 },
                                                    new Futers() { FuterId = 13, FuterName = "Contact", FuterParentId = 5, LanguageId = 2 },
                                                    new Futers() { FuterId = 14, FuterName = "Mobile: 599985226", FuterParentId = 6, LanguageId = 2 },
                                                    new Futers() { FuterId = 15, FuterName = "City: 0995322706389", FuterParentId = 7, LanguageId = 2 },
                                                    new Futers() { FuterId = 16, FuterName = "Addressess: 7th lane of Beri Gabriel Salosi. 10th Cor.", FuterParentId = 8, LanguageId = 2 },


                                                    new Futers() { FuterId = 17, FuterName = "рабочее время", FuterParentId = 1, LanguageId = 3 },
                                                    new Futers() { FuterId = 18, FuterName = "интернет магазин: 24/7", FuterParentId = 2, LanguageId = 3 },
                                                    new Futers() { FuterId = 19, FuterName = "Понедельник-Пятница: 09:00-20:00", FuterParentId = 3, LanguageId = 3 },
                                                    new Futers() { FuterId = 20, FuterName = "выходные: 09:00-18:00", FuterParentId = 4, LanguageId = 3 },
                                                    new Futers() { FuterId = 21, FuterName = "Связаться с нами", FuterParentId = 5, LanguageId = 3 },
                                                    new Futers() { FuterId = 22, FuterName = "Мобильный: 599985226", FuterParentId = 6, LanguageId = 3 },
                                                    new Futers() { FuterId = 23, FuterName = "город: 0995322706389", FuterParentId = 7, LanguageId = 3 },
                                                    new Futers() { FuterId = 24, FuterName = "Адрес: 7th lane of Beri Gabriel Salosi. 10th Cor.", FuterParentId = 8, LanguageId = 3 }
                                                    );


            modelBuilder.Entity<Menus>().HasData(
                                                new Menus() { MenuId = 1, MenuName = "ახალი ელექტრონიქსი", MenuParentId = 1, LanguageId = 1 },
                                                new Menus() { MenuId = 2, MenuName = "პროდუქტი", MenuParentId = 2, LanguageId = 1 },
                                                new Menus() { MenuId = 3, MenuName = "აქციები", MenuParentId = 3, LanguageId = 1 },
                                                new Menus() { MenuId = 4, MenuName = "მიწოდება", MenuParentId = 4, LanguageId = 1 },
                                                new Menus() { MenuId = 5, MenuName = "გადახდა", MenuParentId = 5, LanguageId = 1 },
                                                new Menus() { MenuId = 6, MenuName = "კონტაქტი", MenuParentId = 6, LanguageId = 1 },
                                                new Menus() { MenuId = 7, MenuName = "რეგისტრაცია", MenuParentId = 7, LanguageId = 1 },
                                                new Menus() { MenuId = 8, MenuName = "შესვლა", MenuParentId = 8, LanguageId = 1 },

                                                new Menus() { MenuId = 9, MenuName = "New Electronics", MenuParentId = 1, LanguageId = 2 },
                                                new Menus() { MenuId = 10, MenuName = "Product", MenuParentId = 2, LanguageId = 2 },
                                                new Menus() { MenuId = 11, MenuName = "Promotions", MenuParentId = 3, LanguageId = 2 },
                                                new Menus() { MenuId = 12, MenuName = "Delivery", MenuParentId = 4, LanguageId = 2 },
                                                new Menus() { MenuId = 13, MenuName = "pay", MenuParentId = 5, LanguageId = 2 },
                                                new Menus() { MenuId = 14, MenuName = "Contact", MenuParentId = 6, LanguageId = 2 },
                                                new Menus() { MenuId = 15, MenuName = "Registration", MenuParentId = 7, LanguageId = 2 },
                                                new Menus() { MenuId = 16, MenuName = "Login", MenuParentId = 8, LanguageId = 2 },

                                                new Menus() { MenuId = 17, MenuName = "Новая электроника", MenuParentId = 1, LanguageId = 3 },
                                                new Menus() { MenuId = 18, MenuName = "Продукт", MenuParentId = 2, LanguageId = 3 },
                                                new Menus() { MenuId = 19, MenuName = "промо акции", MenuParentId = 3, LanguageId = 3 },
                                                new Menus() { MenuId = 20, MenuName = "Delivery", MenuParentId = 4, LanguageId = 3 },
                                                new Menus() { MenuId = 21, MenuName = "платить", MenuParentId = 5, LanguageId = 3 },
                                                new Menus() { MenuId = 22, MenuName = "Связаться с нами", MenuParentId = 6, LanguageId = 3 },
                                                new Menus() { MenuId = 23, MenuName = "Регистрация", MenuParentId = 7, LanguageId = 3 },
                                                new Menus() { MenuId = 24, MenuName = "Авторизоваться", MenuParentId = 8, LanguageId = 3 }
                                              );


        }



    }
}
