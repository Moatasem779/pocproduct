using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductPOCModule.Migrations
{
    /// <inheritdoc />
    public partial class add_extraproperties_to_physical : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "PhysicalProductModulePhysicalProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "PhysicalProductModulePhysicalProducts");
        }
    }
}
