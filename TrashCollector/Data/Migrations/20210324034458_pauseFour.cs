using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class pauseFour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20fd1d3a-95fe-47e5-b930-04a94cfb3b4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86f0a312-93ec-4a39-b643-84be0e505684");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e42f09e5-5ecb-488f-bd88-2d8a34d941f8");

            migrationBuilder.CreateTable(
                name: "PauseServicesFours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CustomerZip = table.Column<int>(nullable: false),
                    CustomerFirstName = table.Column<string>(nullable: true),
                    CustomerLastName = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PauseServicesFours", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ac1b480-5333-4440-a6fb-fde10708f11a", "bdc70418-e5cb-43b6-9aef-ab0c2d72b746", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f77966e-8e75-4cec-b9b4-0d16968522a9", "9e663316-884b-4ab8-aa04-7a57b4baeff8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd1cec05-5fd7-49c1-a2f4-9d9baa6cd80d", "3876603b-9195-4baa-8b93-b6dc6e1d3c03", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PauseServicesFours");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f77966e-8e75-4cec-b9b4-0d16968522a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ac1b480-5333-4440-a6fb-fde10708f11a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd1cec05-5fd7-49c1-a2f4-9d9baa6cd80d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e42f09e5-5ecb-488f-bd88-2d8a34d941f8", "887a8aaa-4ba0-45e3-8539-3685661dab4b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20fd1d3a-95fe-47e5-b930-04a94cfb3b4b", "b8bf96ad-a954-4358-a126-ffcbdd9fd150", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "86f0a312-93ec-4a39-b643-84be0e505684", "416644a7-ffb7-47dc-a53b-13881c28bf1e", "Employee", "EMPLOYEE" });
        }
    }
}
