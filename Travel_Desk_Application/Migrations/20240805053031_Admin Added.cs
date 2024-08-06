using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travel_Desk_Application.Migrations
{
    /// <inheritdoc />
    public partial class AdminAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedBy", "CreatedOn", "IsActive", "ModifiedOn", "ModifiyedBy", "RoleName" },
                values: new object[] { 1, 1, new DateTime(2024, 8, 5, 11, 0, 30, 667, DateTimeKind.Local).AddTicks(3920), true, null, null, "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedBy", "CreatedOn", "IsActive", "ModifiedOn", "ModifiyedBy", "RoleName" },
                values: new object[] { 3, 1, new DateTime(2024, 8, 5, 10, 1, 52, 30, DateTimeKind.Local).AddTicks(5972), true, null, null, "HR Admin" });
        }
    }
}
