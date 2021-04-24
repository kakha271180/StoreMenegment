using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreMenegment.Migrations
{
    public partial class StoreManagment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "MyUsers",
                columns: table => new
                {
                    MyUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AspNetUserId = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(75)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    PersonalNumber = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    ElPosta = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Pasword = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyUsers", x => x.MyUserId);
                });

            migrationBuilder.CreateTable(
                name: "ObjectFiles",
                columns: table => new
                {
                    ObjectFileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectName = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    ObjectAddres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectFiles", x => x.ObjectFileId);
                });

            migrationBuilder.CreateTable(
                name: "ProductColors",
                columns: table => new
                {
                    ProductColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductColorName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColors", x => x.ProductColorId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    CityParentId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_CityParentId",
                        column: x => x.CityParentId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    DepartmentParentId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_DepartmentParentId",
                        column: x => x.DepartmentParentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Futers",
                columns: table => new
                {
                    FuterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuterName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    FuterParentId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Futers", x => x.FuterId);
                    table.ForeignKey(
                        name: "FK_FuterParentId",
                        column: x => x.FuterParentId,
                        principalTable: "Futers",
                        principalColumn: "FuterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    MenuParentId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuParentId",
                        column: x => x.MenuParentId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MethodOfPayments",
                columns: table => new
                {
                    MethodOfPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MethodOfPaymentName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    MethodOfPaymentParentId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MethodOfPayments", x => x.MethodOfPaymentId);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MethodOfPaymentParentId",
                        column: x => x.MethodOfPaymentParentId,
                        principalTable: "MethodOfPayments",
                        principalColumn: "MethodOfPaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PosishenTypes",
                columns: table => new
                {
                    PositionTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionTypeName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    PositionTypeParentstId = table.Column<int>(type: "int", nullable: false),
                    PosishenTypeParentstId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosishenTypes", x => x.PositionTypeId);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PosishenTypeParentstId",
                        column: x => x.PosishenTypeParentstId,
                        principalTable: "PosishenTypes",
                        principalColumn: "PositionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Brandies",
                columns: table => new
                {
                    BrandyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandyName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    ObjectFileId = table.Column<int>(type: "int", nullable: false),
                    BrandyParentId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brandies", x => x.BrandyId);
                    table.ForeignKey(
                        name: "FK_BrandyParentId",
                        column: x => x.BrandyParentId,
                        principalTable: "Brandies",
                        principalColumn: "BrandyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectfileId",
                        column: x => x.ObjectFileId,
                        principalTable: "ObjectFiles",
                        principalColumn: "ObjectFileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    CategoryParentId = table.Column<int>(type: "int", nullable: false),
                    ObjectFileId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_CategoryParentId",
                        column: x => x.CategoryParentId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectFileId",
                        column: x => x.ObjectFileId,
                        principalTable: "ObjectFiles",
                        principalColumn: "ObjectFileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Technics",
                columns: table => new
                {
                    TechnicsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechnicsName = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    ObjectFileId = table.Column<int>(type: "int", nullable: false),
                    TechnicParentId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technics", x => x.TechnicsId);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectFileId",
                        column: x => x.ObjectFileId,
                        principalTable: "ObjectFiles",
                        principalColumn: "ObjectFileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechnicParentId",
                        column: x => x.TechnicParentId,
                        principalTable: "Technics",
                        principalColumn: "TechnicsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    AdresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopAdresStritName = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    AdresParentId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    ObjectFileId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.AdresId);
                    table.ForeignKey(
                        name: "FK_AdresParentId",
                        column: x => x.AdresParentId,
                        principalTable: "Adres",
                        principalColumn: "AdresId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectFileId",
                        column: x => x.ObjectFileId,
                        principalTable: "ObjectFiles",
                        principalColumn: "ObjectFileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posishens",
                columns: table => new
                {
                    PosishenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosishenName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PosishenTypeId = table.Column<int>(type: "int", nullable: false),
                    PosishenParentId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posishens", x => x.PosishenId);
                    table.ForeignKey(
                        name: "FK_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PosishenParentId",
                        column: x => x.PosishenParentId,
                        principalTable: "Posishens",
                        principalColumn: "PosishenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PosishenTypeId",
                        column: x => x.PosishenTypeId,
                        principalTable: "PosishenTypes",
                        principalColumn: "PositionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(350)", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(35)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SalesDiscount = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductColorId = table.Column<int>(type: "int", nullable: false),
                    ProductParentID = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    TechnicsId = table.Column<int>(type: "int", nullable: false),
                    BrendiesId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ObjectFileId = table.Column<int>(type: "int", nullable: false),
                    ShopAdreshId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_BrendiesId",
                        column: x => x.BrendiesId,
                        principalTable: "Brandies",
                        principalColumn: "BrandyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectFileId",
                        column: x => x.ObjectFileId,
                        principalTable: "ObjectFiles",
                        principalColumn: "ObjectFileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductColorId",
                        column: x => x.ProductColorId,
                        principalTable: "ProductColors",
                        principalColumn: "ProductColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductParentID",
                        column: x => x.ProductParentID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopAdreshId",
                        column: x => x.ShopAdreshId,
                        principalTable: "Adres",
                        principalColumn: "AdresId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechnicsId",
                        column: x => x.TechnicsId,
                        principalTable: "Technics",
                        principalColumn: "TechnicsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employeess",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirsName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PersonalNumber = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Phone1 = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ElPosta = table.Column<string>(type: "nvarchar(90)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    DateOfReceipt = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    DateOfRelease = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    PosishenId = table.Column<int>(type: "int", nullable: false),
                    BrenchAddresId = table.Column<int>(type: "int", nullable: false),
                    BrenchAddressesId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    EmployeeParentId = table.Column<int>(type: "int", nullable: false),
                    EmployeesParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeess", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_BrenchAddressesId",
                        column: x => x.BrenchAddressesId,
                        principalTable: "Adres",
                        principalColumn: "AdresId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesParentId",
                        column: x => x.EmployeesParentId,
                        principalTable: "Employeess",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PosishenId",
                        column: x => x.PosishenId,
                        principalTable: "Posishens",
                        principalColumn: "PosishenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesGroups",
                columns: table => new
                {
                    EmployeeGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeGroupNumber = table.Column<string>(type: "nvarchar(8)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    EmployeeGroupParentId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesGroups", x => x.EmployeeGroupId);
                    table.ForeignKey(
                        name: "FK_EmployeeGroupParentId",
                        column: x => x.EmployeeGroupParentId,
                        principalTable: "EmployeesGroups",
                        principalColumn: "EmployeeGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employeess",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSolds",
                columns: table => new
                {
                    ProductSoldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DateOfSale = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    InstallmentAmount = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Cash = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    TerminalAmount = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    ObjectFileId = table.Column<int>(type: "int", nullable: false),
                    MethodOfPaymentParentId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeesId = table.Column<int>(type: "int", nullable: true),
                    ProductParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSolds", x => x.ProductSoldId);
                    table.ForeignKey(
                        name: "FK_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employeess",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MethodOfPaymentParentId",
                        column: x => x.MethodOfPaymentParentId,
                        principalTable: "MethodOfPayments",
                        principalColumn: "MethodOfPaymentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectFileId",
                        column: x => x.ObjectFileId,
                        principalTable: "ObjectFiles",
                        principalColumn: "ObjectFileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductParentId",
                        column: x => x.ProductParentId,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SendProductss",
                columns: table => new
                {
                    SendProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    ReceptionistDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    SupplyConfirming = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    SupplyConfirmingDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    SurrenderConfirming = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    SurrenderDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ProductParentId = table.Column<int>(type: "int", nullable: false),
                    SendShopAdresId = table.Column<int>(type: "int", nullable: false),
                    ReceptionistShopAdresId = table.Column<int>(type: "int", nullable: false),
                    SendEmployeeId = table.Column<int>(type: "int", nullable: false),
                    SendEmployeesId = table.Column<int>(type: "int", nullable: true),
                    ReceptionistEmployeeId = table.Column<int>(type: "int", nullable: false),
                    ReceptionistEmployeesId = table.Column<int>(type: "int", nullable: true),
                    FileObjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendProductss", x => x.SendProductID);
                    table.ForeignKey(
                        name: "FK_FileObjectId",
                        column: x => x.FileObjectId,
                        principalTable: "ObjectFiles",
                        principalColumn: "ObjectFileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductParentId",
                        column: x => x.ProductParentId,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceptionistEmployeesId",
                        column: x => x.ReceptionistEmployeesId,
                        principalTable: "Employeess",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceptionistShopAdresId",
                        column: x => x.ReceptionistShopAdresId,
                        principalTable: "Adres",
                        principalColumn: "AdresId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SendEmployeesId",
                        column: x => x.SendEmployeesId,
                        principalTable: "Employeess",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SendShopAdresId",
                        column: x => x.SendShopAdresId,
                        principalTable: "Adres",
                        principalColumn: "AdresId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supplies",
                columns: table => new
                {
                    SupplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ConfirmationOfPerformance = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ConfirmationOfPerformanceDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    EmployeeGroupId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    SupplyParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplies", x => x.SupplyId);
                    table.ForeignKey(
                        name: "FK_EmployeesGroupId",
                        column: x => x.EmployeeGroupId,
                        principalTable: "EmployeesGroups",
                        principalColumn: "EmployeeGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyParentId",
                        column: x => x.SupplyParentId,
                        principalTable: "Supplies",
                        principalColumn: "SupplyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DeliveryService = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "GetDate()"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ConfirmationOfSupply = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ConfirmationOfSupplyDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    ConfirmationOfDelivery = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    ConfirmationOfDeliveryDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    ProductParentID = table.Column<int>(type: "int", nullable: false),
                    MyUserId = table.Column<int>(type: "int", nullable: false),
                    OrderParentId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    SupplyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "MyUsers",
                        principalColumn: "MyUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderParentId",
                        column: x => x.OrderParentId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductParentID",
                        column: x => x.ProductParentID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyId",
                        column: x => x.SupplyId,
                        principalTable: "Supplies",
                        principalColumn: "SupplyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "LanguageName" },
                values: new object[] { 1, "ქართული" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "LanguageName" },
                values: new object[] { 2, "English" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "LanguageName" },
                values: new object[] { 3, "русский" });

            migrationBuilder.InsertData(
                table: "Futers",
                columns: new[] { "FuterId", "FuterName", "FuterParentId", "LanguageId" },
                values: new object[,]
                {
                    { 1, "სამუშაო საათები", 1, 1 },
                    { 2, "ონლაინ მაღაზია: 24/7", 2, 1 },
                    { 3, "ორშაბათი-პარასკევი: 09:00-20:00", 3, 1 },
                    { 4, "შაბათი-კვირა: 09:00-18:00", 4, 1 },
                    { 5, "კონტაქტი", 5, 1 },
                    { 6, "მობილური: 599985226", 6, 1 },
                    { 7, "ქალაქი: 0995322706389", 7, 1 },
                    { 8, "მისამართი: ბერი გაბრიელ სალოსის 7-ე შეს. 10-ე კორ.", 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "LanguageId", "MenuName", "MenuParentId" },
                values: new object[,]
                {
                    { 1, 1, "ახალი ელექტრონიქსი", 1 },
                    { 2, 1, "პროდუქტი", 2 },
                    { 3, 1, "აქციები", 3 },
                    { 4, 1, "მიწოდება", 4 },
                    { 5, 1, "გადახდა", 5 },
                    { 6, 1, "კონტაქტი", 6 },
                    { 7, 1, "რეგისტრაცია", 7 },
                    { 8, 1, "შესვლა", 8 }
                });

            migrationBuilder.InsertData(
                table: "Futers",
                columns: new[] { "FuterId", "FuterName", "FuterParentId", "LanguageId" },
                values: new object[,]
                {
                    { 9, "working hours", 1, 2 },
                    { 16, "Addressess: 7th lane of Beri Gabriel Salosi. 10th Cor.", 8, 2 },
                    { 23, "город: 0995322706389", 7, 3 },
                    { 15, "City: 0995322706389", 7, 2 },
                    { 22, "Мобильный: 599985226", 6, 3 },
                    { 14, "Mobile: 599985226", 6, 2 },
                    { 21, "Связаться с нами", 5, 3 },
                    { 13, "Contact", 5, 2 },
                    { 24, "Адрес: 7th lane of Beri Gabriel Salosi. 10th Cor.", 8, 3 },
                    { 12, "weekend: 09:00-18:00", 4, 2 },
                    { 19, "Понедельник-Пятница: 09:00-20:00", 3, 3 },
                    { 11, "Monday-Friday: 09:00-20:00", 3, 2 },
                    { 18, "интернет магазин: 24/7", 2, 3 },
                    { 10, "online shop: 24/7", 2, 2 },
                    { 17, "рабочее время", 1, 3 },
                    { 20, "выходные: 09:00-18:00", 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "LanguageId", "MenuName", "MenuParentId" },
                values: new object[,]
                {
                    { 23, 3, "Регистрация", 7 },
                    { 15, 2, "Registration", 7 },
                    { 22, 3, "Связаться с нами", 6 },
                    { 14, 2, "Contact", 6 },
                    { 21, 3, "платить", 5 },
                    { 13, 2, "pay", 5 },
                    { 20, 3, "Delivery", 4 },
                    { 11, 2, "Promotions", 3 },
                    { 19, 3, "промо акции", 3 },
                    { 18, 3, "Продукт", 2 },
                    { 10, 2, "Product", 2 },
                    { 17, 3, "Новая электроника", 1 },
                    { 9, 2, "New Electronics", 1 },
                    { 16, 2, "Login", 8 },
                    { 12, 2, "Delivery", 4 },
                    { 24, 3, "Авторизоваться", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adres_AdresParentId",
                table: "Adres",
                column: "AdresParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Adres_CityId",
                table: "Adres",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Adres_LanguageId",
                table: "Adres",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Adres_ObjectFileId",
                table: "Adres",
                column: "ObjectFileId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Brandies_BrandyParentId",
                table: "Brandies",
                column: "BrandyParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Brandies_LanguageId",
                table: "Brandies",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Brandies_ObjectFileId",
                table: "Brandies",
                column: "ObjectFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryParentId",
                table: "Categories",
                column: "CategoryParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_LanguageId",
                table: "Categories",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ObjectFileId",
                table: "Categories",
                column: "ObjectFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CityParentId",
                table: "Cities",
                column: "CityParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_LanguageId",
                table: "Cities",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentParentId",
                table: "Departments",
                column: "DepartmentParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_LanguageId",
                table: "Departments",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesGroups_EmployeeGroupParentId",
                table: "EmployeesGroups",
                column: "EmployeeGroupParentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesGroups_EmployeesId",
                table: "EmployeesGroups",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesGroups_LanguageId",
                table: "EmployeesGroups",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Employeess_BrenchAddressesId",
                table: "Employeess",
                column: "BrenchAddressesId");

            migrationBuilder.CreateIndex(
                name: "IX_Employeess_EmployeesParentId",
                table: "Employeess",
                column: "EmployeesParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employeess_LanguageId",
                table: "Employeess",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Employeess_PosishenId",
                table: "Employeess",
                column: "PosishenId");

            migrationBuilder.CreateIndex(
                name: "IX_Futers_FuterParentId",
                table: "Futers",
                column: "FuterParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Futers_LanguageId",
                table: "Futers",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_LanguageId",
                table: "Menus",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuParentId",
                table: "Menus",
                column: "MenuParentId");

            migrationBuilder.CreateIndex(
                name: "IX_MethodOfPayments_LanguageId",
                table: "MethodOfPayments",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_MethodOfPayments_MethodOfPaymentParentId",
                table: "MethodOfPayments",
                column: "MethodOfPaymentParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_LanguageId",
                table: "Orders",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MyUserId",
                table: "Orders",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderParentId",
                table: "Orders",
                column: "OrderParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductParentID",
                table: "Orders",
                column: "ProductParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SupplyId",
                table: "Orders",
                column: "SupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Posishens_DepartmentId",
                table: "Posishens",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Posishens_LanguageId",
                table: "Posishens",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Posishens_PosishenParentId",
                table: "Posishens",
                column: "PosishenParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Posishens_PosishenTypeId",
                table: "Posishens",
                column: "PosishenTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PosishenTypes_LanguageId",
                table: "PosishenTypes",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PosishenTypes_PosishenTypeParentstId",
                table: "PosishenTypes",
                column: "PosishenTypeParentstId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrendiesId",
                table: "Products",
                column: "BrendiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LanguageId",
                table: "Products",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ObjectFileId",
                table: "Products",
                column: "ObjectFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductColorId",
                table: "Products",
                column: "ProductColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductParentID",
                table: "Products",
                column: "ProductParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShopAdreshId",
                table: "Products",
                column: "ShopAdreshId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TechnicsId",
                table: "Products",
                column: "TechnicsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSolds_EmployeesId",
                table: "ProductSolds",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSolds_MethodOfPaymentParentId",
                table: "ProductSolds",
                column: "MethodOfPaymentParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSolds_ObjectFileId",
                table: "ProductSolds",
                column: "ObjectFileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSolds_ProductParentId",
                table: "ProductSolds",
                column: "ProductParentId");

            migrationBuilder.CreateIndex(
                name: "IX_SendProductss_FileObjectId",
                table: "SendProductss",
                column: "FileObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SendProductss_ProductParentId",
                table: "SendProductss",
                column: "ProductParentId");

            migrationBuilder.CreateIndex(
                name: "IX_SendProductss_ReceptionistEmployeesId",
                table: "SendProductss",
                column: "ReceptionistEmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_SendProductss_ReceptionistShopAdresId",
                table: "SendProductss",
                column: "ReceptionistShopAdresId");

            migrationBuilder.CreateIndex(
                name: "IX_SendProductss_SendEmployeesId",
                table: "SendProductss",
                column: "SendEmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_SendProductss_SendShopAdresId",
                table: "SendProductss",
                column: "SendShopAdresId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplies_EmployeeGroupId",
                table: "Supplies",
                column: "EmployeeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplies_LanguageId",
                table: "Supplies",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplies_SupplyParentId",
                table: "Supplies",
                column: "SupplyParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Technics_LanguageId",
                table: "Technics",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Technics_ObjectFileId",
                table: "Technics",
                column: "ObjectFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Technics_TechnicParentId",
                table: "Technics",
                column: "TechnicParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Futers");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductSolds");

            migrationBuilder.DropTable(
                name: "SendProductss");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MyUsers");

            migrationBuilder.DropTable(
                name: "Supplies");

            migrationBuilder.DropTable(
                name: "MethodOfPayments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "EmployeesGroups");

            migrationBuilder.DropTable(
                name: "Brandies");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ProductColors");

            migrationBuilder.DropTable(
                name: "Technics");

            migrationBuilder.DropTable(
                name: "Employeess");

            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropTable(
                name: "Posishens");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "ObjectFiles");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "PosishenTypes");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
