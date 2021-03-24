using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class pauseThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27d45053-e674-4194-887a-ff2b217ddd23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43a2c67c-65ba-4427-9ca8-6350c7523b61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfc35977-c015-416f-8b92-42d2819a4ce9");

            migrationBuilder.CreateTable(
                name: "PauseServicesThree",
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
                    table.PrimaryKey("PK_PauseServicesThree", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PauseServicesThree_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PauseServicesThree_CustomerId",
                table: "PauseServicesThree",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PauseServicesThree");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27d45053-e674-4194-887a-ff2b217ddd23", "191c42f4-e607-408f-8ec4-495c55edd980", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43a2c67c-65ba-4427-9ca8-6350c7523b61", "5d65b243-8273-4692-b78a-8326d9f97dc2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfc35977-c015-416f-8b92-42d2819a4ce9", "fef73d9b-639a-4cdb-9dd3-4455959ee2f9", "Employee", "EMPLOYEE" });
        }
    }
}
