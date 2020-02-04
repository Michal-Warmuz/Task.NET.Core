using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task.Data.Migrations
{
    public partial class addProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Guests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Guests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Guests",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ZIP",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 28, 3, 70, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 28, 3, 72, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 28, 3, 72, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 28, 3, 72, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 28, 3, 72, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 28, 3, 72, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Guests");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ZIP",
                value: "");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 23, 47, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 23, 47, 12, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 23, 47, 12, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 23, 47, 12, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 23, 47, 12, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 31, 21, 23, 47, 12, DateTimeKind.Local));
        }
    }
}
