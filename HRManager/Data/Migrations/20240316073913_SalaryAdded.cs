using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class SalaryAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "AspNetUsers");
        }
    }
}
