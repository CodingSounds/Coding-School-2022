using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.EF.Migrations
{
    public partial class delproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_PetShopClass_PetShopClassId",
                table: "Employee");

            migrationBuilder.AlterColumn<Guid>(
                name: "PetShopClassId",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_PetShopClass_PetShopClassId",
                table: "Employee",
                column: "PetShopClassId",
                principalTable: "PetShopClass",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_PetShopClass_PetShopClassId",
                table: "Employee");

            migrationBuilder.AlterColumn<Guid>(
                name: "PetShopClassId",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_PetShopClass_PetShopClassId",
                table: "Employee",
                column: "PetShopClassId",
                principalTable: "PetShopClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
