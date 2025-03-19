using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductPOCModule.Migrations
{
    /// <inheritdoc />
    public partial class AddPhysicalProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhysicalProductModulePhysicalProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalProductModulePhysicalProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalProductModulePhysicalProducts_BaseProductModuleBaseProducts_Id",
                        column: x => x.Id,
                        principalTable: "BaseProductModuleBaseProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhysicalProductModulePhysicalProducts");
        }
    }
}
