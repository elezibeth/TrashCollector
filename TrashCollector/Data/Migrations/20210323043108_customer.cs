using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69f9e672-047d-4550-b1e3-a6d254403376");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd20817f-eecc-41cd-b5ab-4d96fe34f2fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd92b033-86b4-467e-b727-d5f6deaebbe9");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9e1bf63-b2d9-4886-aa88-73a79532649f", "4b293e16-c384-4ee5-8017-51f3d09daa59", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c3dfef6-a25e-43a5-9113-361a4cbcff9e", "9828cc33-cc00-4729-ac38-0fd840985445", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b31bb92-6cdd-4fa1-8c91-15c02dbd31d6", "53c22fd8-12c7-4e5e-8008-fcb7f489266d", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b31bb92-6cdd-4fa1-8c91-15c02dbd31d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c3dfef6-a25e-43a5-9113-361a4cbcff9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9e1bf63-b2d9-4886-aa88-73a79532649f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd92b033-86b4-467e-b727-d5f6deaebbe9", "a45d7a72-bb0b-4bef-b4d4-808e2779db93", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69f9e672-047d-4550-b1e3-a6d254403376", "c6df1b1f-c875-4c77-8600-886153f71c85", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd20817f-eecc-41cd-b5ab-4d96fe34f2fe", "f6b048cb-a3ca-422a-8d41-18d7ece448dd", "Employee", "EMPLOYEE" });
        }
    }
}
