using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Add_Seeding_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "protfolioItems",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "owniers",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "owniers",
                columns: new[] { "Id", "Address", "Avatar", "FullName", "Job" },
                values: new object[] { new Guid("c810ae61-bdee-4f77-80ce-87cc56d170a6"), "Khartoum - sudan", "avatar.jpg", "Ahmed Khaojaly Ahmed Ali", "Web Development - DotNet - API Intigration" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "owniers",
                keyColumn: "Id",
                keyValue: new Guid("c810ae61-bdee-4f77-80ce-87cc56d170a6"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "protfolioItems",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "owniers",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");
        }
    }
}
