using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class DeleteInstallment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Installment",
                table: "Memberships");

            migrationBuilder.AlterColumn<decimal>(
                name: "SignupFee",
                table: "Memberships",
                type: "DECIMAL(12,2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Memberships",
                type: "DECIMAL(12,2)",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SignupFee",
                table: "Memberships",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Memberships",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(12,2)");

            migrationBuilder.AddColumn<decimal>(
                name: "Installment",
                table: "Memberships",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
