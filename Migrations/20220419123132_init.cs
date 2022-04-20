using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testweb.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Vacancies",
                columns: new[] { "Id", "Company", "Date" },
                values: new object[] { 1L, "First", new DateTime(2022, 4, 19, 15, 31, 32, 30, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.InsertData(
                table: "Vacancies",
                columns: new[] { "Id", "Company", "Date" },
                values: new object[] { 2L, "Second", new DateTime(2022, 4, 19, 15, 31, 32, 31, DateTimeKind.Local).AddTicks(1765) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacancies");
        }
    }
}
