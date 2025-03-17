using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductPOCModule.Migrations
{
    /// <inheritdoc />
    public partial class addauditedtobaseproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "BaseProductModuleBaseProducts");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "BaseProductModuleBaseProducts");

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "BaseProductModuleBaseProducts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "BaseProductModuleBaseProducts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BaseProductModuleBaseProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "BaseProductModuleBaseProducts");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "BaseProductModuleBaseProducts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BaseProductModuleBaseProducts");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "BaseProductModuleBaseProducts",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "BaseProductModuleBaseProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
