using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maestro.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SH_User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    Changed = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SH_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UT_City",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    Changed = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UT_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UT_Town",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    Changed = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UT_Town", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UT_Town_UT_City_CityId",
                        column: x => x.CityId,
                        principalTable: "UT_City",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UT_Town_CityId",
                table: "UT_Town",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SH_User");

            migrationBuilder.DropTable(
                name: "UT_Town");

            migrationBuilder.DropTable(
                name: "UT_City");
        }
    }
}
