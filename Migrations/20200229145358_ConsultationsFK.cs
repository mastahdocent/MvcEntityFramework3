using Microsoft.EntityFrameworkCore.Migrations;

namespace Rozdzial3_C.Migrations
{
    public partial class ConsultationsFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Customers_CustomerModelID",
                table: "Consultations");

            migrationBuilder.DropIndex(
                name: "IX_Consultations_CustomerModelID",
                table: "Consultations");

            migrationBuilder.DropColumn(
                name: "CustomerModelID",
                table: "Consultations");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Consultations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_CustomerID",
                table: "Consultations",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Customers_CustomerID",
                table: "Consultations",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Customers_CustomerID",
                table: "Consultations");

            migrationBuilder.DropIndex(
                name: "IX_Consultations_CustomerID",
                table: "Consultations");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Consultations");

            migrationBuilder.AddColumn<int>(
                name: "CustomerModelID",
                table: "Consultations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_CustomerModelID",
                table: "Consultations",
                column: "CustomerModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Customers_CustomerModelID",
                table: "Consultations",
                column: "CustomerModelID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
