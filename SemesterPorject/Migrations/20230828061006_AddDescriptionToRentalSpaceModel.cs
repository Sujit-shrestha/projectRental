using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SemesterPorject.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionToRentalSpaceModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RentalSpace",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "RentalSpace");
        }
    }
}
