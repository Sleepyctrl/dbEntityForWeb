using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dbEntityForWeb.Migrations
{
    public partial class firstrefernce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companys",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyDetails",
                table: "Companys",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Clients",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Clients",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CompanyId",
                table: "Clients",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_PaymentId",
                table: "Clients",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Companys_CompanyId",
                table: "Clients",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Payments_PaymentId",
                table: "Clients",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Companys_CompanyId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Payments_PaymentId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_CompanyId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_PaymentId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companys",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyDetails",
                table: "Companys",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
