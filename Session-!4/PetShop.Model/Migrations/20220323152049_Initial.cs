using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.EF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetShopClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetShopClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tin = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PetShopClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customer_PetShopClass_PetShopClassId",
                        column: x => x.PetShopClassId,
                        principalTable: "PetShopClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpType = table.Column<int>(type: "int", nullable: false),
                    PetShopClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_PetShopClass_PetShopClassId",
                        column: x => x.PetShopClassId,
                        principalTable: "PetShopClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PetFood",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PetShopClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetFood", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PetFood_PetShopClass_PetShopClassId",
                        column: x => x.PetShopClassId,
                        principalTable: "PetShopClass",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetShopClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetFoodQty = table.Column<int>(type: "int", nullable: false),
                    PetFoodPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transaction_PetShopClass_PetShopClassId",
                        column: x => x.PetShopClassId,
                        principalTable: "PetShopClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetShopClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_PetShopClass_PetShopClassId",
                        column: x => x.PetShopClassId,
                        principalTable: "PetShopClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HealthStatus = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    AnimalType = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PetShopClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ObjectStatus = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pet_PetFood_FoodTypeID",
                        column: x => x.FoodTypeID,
                        principalTable: "PetFood",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_PetShopClass_PetShopClassId",
                        column: x => x.PetShopClassId,
                        principalTable: "PetShopClass",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PetShopClassId",
                table: "Customer",
                column: "PetShopClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PetShopClassId",
                table: "Employee",
                column: "PetShopClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_FoodTypeID",
                table: "Pet",
                column: "FoodTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_PetShopClassId",
                table: "Pet",
                column: "PetShopClassId");

            migrationBuilder.CreateIndex(
                name: "IX_PetFood_PetShopClassId",
                table: "PetFood",
                column: "PetShopClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PetShopClassId",
                table: "Transaction",
                column: "PetShopClassId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PetShopClassId",
                table: "User",
                column: "PetShopClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "PetFood");

            migrationBuilder.DropTable(
                name: "PetShopClass");
        }
    }
}
