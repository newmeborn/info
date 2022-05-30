using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace info.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "infomeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    illness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sales = table.Column<int>(type: "int", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    Expiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    medicinetype = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
