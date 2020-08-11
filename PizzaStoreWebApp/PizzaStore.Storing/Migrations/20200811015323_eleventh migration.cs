using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaStore.Storing.Migrations
{
    public partial class eleventhmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastOrdererd",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserModelId",
                table: "Orders",
                column: "UserModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserModelId",
                table: "Orders",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserModelId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserModelId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LastOrdererd",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "Orders");
        }
    }
}
