using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBCodeFirst.Migrations
{
    public partial class Fisrt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirtsName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telephone = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Email", "FirtsName", "Lastname", "Telephone" },
                values: new object[,]
                {
                    { 1, "dhjkfk@sdk.co", "John", "Smith", 958762012L },
                    { 2, "aaak@sdk.co", "Nastya", "Hlusenko", 958768012L },
                    { 3, "lllk@sdk.co", "Lena", "Lohvinova", 508768012L },
                    { 4, "nnnk@sdk.co", "Nastya", "Zemlyanskaya", 508766511L },
                    { 5, "ssss@sdk.co", "Alena", "Ss", 508876511L }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 200m, 1, "A", new DateTime(2022, 7, 11, 16, 35, 45, 875, DateTimeKind.Local).AddTicks(5463) },
                    { 2, 200m, 2, "Б", new DateTime(2022, 7, 11, 16, 35, 45, 875, DateTimeKind.Local).AddTicks(5494) },
                    { 3, 200m, 3, "В", new DateTime(2022, 7, 11, 16, 35, 45, 875, DateTimeKind.Local).AddTicks(5496) },
                    { 4, 200m, 4, "Г", new DateTime(2022, 7, 11, 16, 35, 45, 875, DateTimeKind.Local).AddTicks(5498) },
                    { 5, 200m, 5, "Д", new DateTime(2022, 7, 11, 16, 35, 45, 875, DateTimeKind.Local).AddTicks(5500) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Clients_ClientId",
                table: "Project",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Clients_ClientId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Project_ClientId",
                table: "Project");

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Project");
        }
    }
}
