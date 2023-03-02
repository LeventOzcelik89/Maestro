using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maestro.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class M2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "aaaaa",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "aaaaa",
                table: "BaseEntity");
        }
    }
}
