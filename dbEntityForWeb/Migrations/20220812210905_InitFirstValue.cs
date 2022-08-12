using dbEntityForWeb.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dbEntityForWeb.Migrations
{
    public partial class InitFirstValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // TABLE COMPANY
            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { nameof(Company.Name), nameof(Company.CompanyDetails)},
                values: new object[] {
                "Microfibra",
                "Sovetskaya street, house 13, appartment 26"});
            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { nameof(Company.Name), nameof(Company.CompanyDetails) },
                values: new object[] {
                "Lesopoval",
                "Lesnoy pereylok street, house 3, appartment 1"});
            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { nameof(Company.Name), nameof(Company.CompanyDetails) },
                values: new object[] {
                "Sektar",
                "Liniskuy prospeckt street, house 24, appartment 3"});

            
            // TABLE PAYMENT

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { nameof(Payment.Cost), nameof(Payment.Contributed),nameof(Payment.Paid) },
                values: new object[] {
                1405,
                1405,
                true});

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { nameof(Payment.Cost), nameof(Payment.Contributed), nameof(Payment.Paid) },
                values: new object[] {
                1405,
                1425,
                true});

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { nameof(Payment.Cost), nameof(Payment.Contributed), nameof(Payment.Paid) },
                values: new object[] {
                1405,
                1400,
                false});

            //  TABLE CLIENT

            migrationBuilder.InsertData(
                table: "Clients", 
                columns: new[] {nameof(Client.Name),nameof(Client.PhoneNumber),nameof(Client.CurrentCompanyId), "PaymentId" },
                values: new object[] {
                "Max",
                89641443826,
                3,
                1});
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { nameof(Client.Name), nameof(Client.PhoneNumber), nameof(Client.CurrentCompanyId), "PaymentId" },
                values: new object[] {
                "Gector",
                11641443826,
                2,
                2});
            migrationBuilder.InsertData(
               table: "Clients",
               columns: new[] { nameof(Client.Name), nameof(Client.PhoneNumber), nameof(Client.CurrentCompanyId), "PaymentId" },
               values: new object[] {
                "Sofia",
                896422243826,
                1,
                3});

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // TABLE COMPANY

            migrationBuilder
                .DeleteData(table: "Companys",
                keyColumn: nameof(Company.Name),
                keyValue: "Microfibra");
            migrationBuilder
                .DeleteData(table: "Companys",
                keyColumn: nameof(Company.Name),
                keyValue: "Lesopoval");
            migrationBuilder
                .DeleteData(table: "Companys",
                keyColumn: nameof(Company.Name),
                keyValue: "Sektar");

            // TABLE PAYMENT

            migrationBuilder
                .DeleteData(table: "Payments",
                keyColumn: nameof(Payment.Id),
                keyValue: 1);
            migrationBuilder
                .DeleteData(table: "Payments",
                keyColumn: nameof(Payment.Id),
                keyValue: 2);
            migrationBuilder
                .DeleteData(table: "Payments",
                keyColumn: nameof(Payment.Id),
                keyValue: 3);

            //  TABLE CLIENT

            migrationBuilder
                .DeleteData(table: "Clients",
                keyColumn: nameof(Client.Name),
                keyValue: "Max");
            migrationBuilder
                .DeleteData(table: "Clients",
                keyColumn: nameof(Client.Name),
                keyValue: "Gector");
            migrationBuilder
                .DeleteData(table: "Clients",
                keyColumn: nameof(Client.Name),
                keyValue: "Sofia");


        }
    }
}
