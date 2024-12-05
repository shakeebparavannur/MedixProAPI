using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedixProDAL.Migrations
{
    /// <inheritdoc />
    public partial class CustomerProfileupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateofBirth",
                table: "CustomerProfiles",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateofBirth",
                table: "CustomerProfiles");
        }
    }
}
