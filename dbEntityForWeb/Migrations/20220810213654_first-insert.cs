using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dbEntityForWeb.Migrations
{
    public partial class firstinsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Companys_CompanyId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Payments_PaymentId",
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

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Clients",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Clients",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Companys_CompanyId",
                table: "Clients",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Payments_PaymentId",
                table: "Clients",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Companys_CompanyId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Payments_PaymentId",
                table: "Clients");

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

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Clients",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Clients",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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
    }
}
