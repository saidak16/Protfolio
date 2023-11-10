using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Update_Contact_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "owniers",
                keyColumn: "Id",
                keyValue: new Guid("c810ae61-bdee-4f77-80ce-87cc56d170a6"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "contacts",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "owniers",
                columns: new[] { "Id", "Address", "Avatar", "FullName", "Job" },
                values: new object[] { new Guid("716b1729-3f66-449b-8b52-6ab05ff3c3cc"), "Khartoum - sudan", "avatar.jpg", "Ahmed Khaojaly Ahmed Ali", "Web Development - DotNet - API Intigration" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "owniers",
                keyColumn: "Id",
                keyValue: new Guid("716b1729-3f66-449b-8b52-6ab05ff3c3cc"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "contacts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.InsertData(
                table: "owniers",
                columns: new[] { "Id", "Address", "Avatar", "FullName", "Job" },
                values: new object[] { new Guid("c810ae61-bdee-4f77-80ce-87cc56d170a6"), "Khartoum - sudan", "avatar.jpg", "Ahmed Khaojaly Ahmed Ali", "Web Development - DotNet - API Intigration" });
        }
    }
}
