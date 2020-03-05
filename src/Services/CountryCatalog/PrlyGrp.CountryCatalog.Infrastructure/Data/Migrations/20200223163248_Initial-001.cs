using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrlyGrp.CountryCatalog.Infrastructure.Data.Migrations
{
    public partial class Initial001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //The initial database infracstructure was previously created

            //migrationBuilder.CreateTable(
            //    name: "Country",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IsActive = table.Column<bool>(nullable: false),
            //        CreatedOn = table.Column<DateTimeOffset>(nullable: false),
            //        CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
            //        ChangedOn = table.Column<DateTimeOffset>(nullable: false),
            //        ChangedBy = table.Column<string>(maxLength: 50, nullable: false),
            //        IsDeleted = table.Column<bool>(nullable: false),
            //        DeletedOn = table.Column<DateTimeOffset>(nullable: true),
            //        DeletedBy = table.Column<string>(maxLength: 50, nullable: true),
            //        Name = table.Column<string>(maxLength: 100, nullable: false),
            //        ShortName = table.Column<string>(maxLength: 20, nullable: false),
            //        Code = table.Column<string>(maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Country", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EavEntity",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IsActive = table.Column<bool>(nullable: false),
            //        CreatedOn = table.Column<DateTimeOffset>(nullable: false),
            //        CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
            //        ChangedOn = table.Column<DateTimeOffset>(nullable: false),
            //        ChangedBy = table.Column<string>(maxLength: 50, nullable: false),
            //        IsDeleted = table.Column<bool>(nullable: false),
            //        DeletedOn = table.Column<DateTimeOffset>(nullable: true),
            //        DeletedBy = table.Column<string>(maxLength: 50, nullable: true),
            //        Name = table.Column<string>(maxLength: 100, nullable: false),
            //        ShortName = table.Column<string>(maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EavEntity", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "StateProvince",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IsActive = table.Column<bool>(nullable: false),
            //        CreatedOn = table.Column<DateTimeOffset>(nullable: false),
            //        CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
            //        ChangedOn = table.Column<DateTimeOffset>(nullable: false),
            //        ChangedBy = table.Column<string>(maxLength: 50, nullable: false),
            //        IsDeleted = table.Column<bool>(nullable: false),
            //        DeletedOn = table.Column<DateTimeOffset>(nullable: true),
            //        DeletedBy = table.Column<string>(maxLength: 20, nullable: true),
            //        Name = table.Column<string>(maxLength: 100, nullable: false),
            //        ShortName = table.Column<string>(maxLength: 20, nullable: false),
            //        Code = table.Column<string>(maxLength: 20, nullable: false),
            //        CountryId = table.Column<int>(nullable: false),
            //        CountryCode = table.Column<string>(maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_StateProvince", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_StateProvince_Country",
            //            column: x => x.CountryId,
            //            principalTable: "Country",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EavAttribute",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IsActive = table.Column<bool>(nullable: false),
            //        CreatedOn = table.Column<DateTimeOffset>(nullable: false),
            //        CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
            //        ChangedOn = table.Column<DateTimeOffset>(nullable: false),
            //        ChangedBy = table.Column<string>(maxLength: 50, nullable: false),
            //        IsDeleted = table.Column<bool>(nullable: false),
            //        DeletedOn = table.Column<DateTimeOffset>(nullable: true),
            //        DeletedBy = table.Column<string>(maxLength: 50, nullable: true),
            //        Name = table.Column<string>(maxLength: 100, nullable: false),
            //        ShortName = table.Column<string>(maxLength: 20, nullable: false),
            //        Label = table.Column<string>(maxLength: 20, nullable: false),
            //        DataType = table.Column<string>(maxLength: 25, nullable: false),
            //        DefaultValue = table.Column<string>(maxLength: 255, nullable: true),
            //        IsRequired = table.Column<bool>(nullable: false),
            //        DisplayOrder = table.Column<int>(nullable: false),
            //        EavEntityId = table.Column<int>(nullable: false),
            //        EavEntityShortName = table.Column<string>(maxLength: 20, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EavAttribute", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_EavAttribute_EavEntity",
            //            column: x => x.EavEntityId,
            //            principalTable: "EavEntity",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EavValue",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IsActive = table.Column<bool>(nullable: false),
            //        CreatedOn = table.Column<DateTimeOffset>(nullable: false),
            //        CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
            //        ChangedOn = table.Column<DateTimeOffset>(nullable: false),
            //        ChangedBy = table.Column<string>(maxLength: 50, nullable: false),
            //        IsDeleted = table.Column<bool>(nullable: false),
            //        DeletedOn = table.Column<DateTimeOffset>(nullable: true),
            //        DeletedBy = table.Column<string>(maxLength: 50, nullable: true),
            //        EntityId = table.Column<int>(nullable: false),
            //        EavEntityId = table.Column<int>(nullable: false),
            //        EavEntityShortName = table.Column<string>(maxLength: 20, nullable: true),
            //        EavAttributeId = table.Column<int>(nullable: false),
            //        EavAttributeShortName = table.Column<string>(maxLength: 20, nullable: true),
            //        Value = table.Column<string>(maxLength: 255, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EavValue", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_EavValue_EavAttribute",
            //            column: x => x.EavAttributeId,
            //            principalTable: "EavAttribute",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_EavValue_EavEntity",
            //            column: x => x.EavEntityId,
            //            principalTable: "EavEntity",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_EavAttribute_EavEntityId",
            //    table: "EavAttribute",
            //    column: "EavEntityId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_EavValue_EavAttributeId",
            //    table: "EavValue",
            //    column: "EavAttributeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_EavValue_EavEntityId",
            //    table: "EavValue",
            //    column: "EavEntityId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StateProvince_CountryId",
            //    table: "StateProvince",
            //    column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EavValue");

            migrationBuilder.DropTable(
                name: "StateProvince");

            migrationBuilder.DropTable(
                name: "EavAttribute");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "EavEntity");
        }
    }
}
