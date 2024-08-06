using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travel_Desk_Application.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 5, 18, 20, 17, 284, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "RoleID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                newName: "IX_Users_RoleID");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 5, 11, 0, 30, 667, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleID",
                table: "Users",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
