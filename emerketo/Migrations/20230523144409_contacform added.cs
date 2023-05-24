using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace emerketo.Migrations
{
    /// <inheritdoc />
    public partial class contacformadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "ContactForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "ContactForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "ContactForms");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "ContactForms");
        }
    }
}
