using Microsoft.EntityFrameworkCore.Migrations;

namespace Rozdzial3_C.Migrations
{
    public partial class Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AddressModel_Customers_ID",
                        column: x => x.ID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressModel");
        }
    }
}
