using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SemesterPorject.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingRentalSpaceModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lister",
                table: "RentalSpace",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lister",
                table: "RentalSpace");
        }
    }
}
