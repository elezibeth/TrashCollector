using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class pauseRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03ecd10e-081f-4da7-9375-b2be0d7f9b1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5a3bd66-836b-4c8a-a625-e280b358f070");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b777d6ee-c681-44bc-b95a-f448d0186b2a");

            migrationBuilder.CreateTable(
                name: "PauseServiceRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CustomerZip = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PauseServiceRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PauseServiceRequests_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PauseServiceRequests_CustomerId",
                table: "PauseServiceRequests",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PauseServiceRequests");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03ecd10e-081f-4da7-9375-b2be0d7f9b1b", "78e6fb9d-6b29-425d-a930-7d52bf986caf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b777d6ee-c681-44bc-b95a-f448d0186b2a", "c0d83ba0-cc81-4aca-89de-ed7b2e78f965", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5a3bd66-836b-4c8a-a625-e280b358f070", "5e70cd73-53aa-4e44-bd46-61acec923520", "Employee", "EMPLOYEE" });
        }
    }
}
