using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductPOCModule.Migrations
{
    /// <inheritdoc />
    public partial class add_physicalmodule_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "BaseProductSequence");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "BaseProductModuleBaseProducts",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [BaseProductSequence]",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "PhysicalProductModulePhysicalProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [BaseProductSequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalProductModulePhysicalProducts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhysicalProductModulePhysicalProducts");

            migrationBuilder.DropSequence(
                name: "BaseProductSequence");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "BaseProductModuleBaseProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [BaseProductSequence]")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
