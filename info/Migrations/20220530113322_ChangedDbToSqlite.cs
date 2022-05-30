using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace info.Migrations
{
    public partial class ChangedDbToSqlite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "infomeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    BrandName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    illness = table.Column<string>(type: "TEXT", nullable: false),
                    sales = table.Column<int>(type: "INTEGER", nullable: false),
                    stock = table.Column<int>(type: "INTEGER", nullable: false),
                    Expiry = table.Column<DateTime>(type: "TEXT", nullable: false),
                    medicinetype = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayOrder = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_infomeds", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "infomeds");
        }
    }
}
