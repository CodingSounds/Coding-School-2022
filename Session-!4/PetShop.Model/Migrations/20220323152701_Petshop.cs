using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.EF.Migrations
{
    public partial class Petshop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_PetShopClass_PetShopClassId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_PetShopClass_PetShopClassId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_PetShopClass_PetShopClassId",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_PetShopClass_PetShopClassId",
                table: "PetFood");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_PetShopClass_PetShopClassId",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_User_PetShopClass_PetShopClassId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetShopClass",
                table: "PetShopClass");

            migrationBuilder.RenameTable(
                name: "PetShopClass",
                newName: "PetShopClasses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetShopClasses",
                table: "PetShopClasses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_PetShopClasses_PetShopClassId",
                table: "Customer",
                column: "PetShopClassId",
                principalTable: "PetShopClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_PetShopClasses_PetShopClassId",
                table: "Employee",
                column: "PetShopClassId",
                principalTable: "PetShopClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_PetShopClasses_PetShopClassId",
                table: "Pet",
                column: "PetShopClassId",
                principalTable: "PetShopClasses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PetFood_PetShopClasses_PetShopClassId",
                table: "PetFood",
                column: "PetShopClassId",
                principalTable: "PetShopClasses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_PetShopClasses_PetShopClassId",
                table: "Transaction",
                column: "PetShopClassId",
                principalTable: "PetShopClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_PetShopClasses_PetShopClassId",
                table: "User",
                column: "PetShopClassId",
                principalTable: "PetShopClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_PetShopClasses_PetShopClassId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_PetShopClasses_PetShopClassId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_PetShopClasses_PetShopClassId",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_PetShopClasses_PetShopClassId",
                table: "PetFood");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_PetShopClasses_PetShopClassId",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_User_PetShopClasses_PetShopClassId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetShopClasses",
                table: "PetShopClasses");

            migrationBuilder.RenameTable(
                name: "PetShopClasses",
                newName: "PetShopClass");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetShopClass",
                table: "PetShopClass",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_PetShopClass_PetShopClassId",
                table: "Customer",
                column: "PetShopClassId",
                principalTable: "PetShopClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_PetShopClass_PetShopClassId",
                table: "Employee",
                column: "PetShopClassId",
                principalTable: "PetShopClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_PetShopClass_PetShopClassId",
                table: "Pet",
                column: "PetShopClassId",
                principalTable: "PetShopClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PetFood_PetShopClass_PetShopClassId",
                table: "PetFood",
                column: "PetShopClassId",
                principalTable: "PetShopClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_PetShopClass_PetShopClassId",
                table: "Transaction",
                column: "PetShopClassId",
                principalTable: "PetShopClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_PetShopClass_PetShopClassId",
                table: "User",
                column: "PetShopClassId",
                principalTable: "PetShopClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
