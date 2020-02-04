using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task.Data.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "ZIP" },
                values: new object[,]
                {
                    { 1L, null, "jan@wp.pl", "Jan", "Nowak", "12-123" },
                    { 2L, null, "janusz@wp.pl", "Janusz", "Nowakowski", "42-123" },
                    { 3L, null, "kamila@wp.pl", "Kamila", "Seweryn", "33-133" },
                    { 4L, null, "ola@wp.pl", "Ola", "Nacht", "" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "Code", "CreatedAt", "Currency", "Price", "Provision", "Source" },
                values: new object[,]
                {
                    { 1L, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AASS!2", new DateTime(2020, 1, 31, 21, 23, 47, 9, DateTimeKind.Local), "PLN", 345m, null, null },
                    { 2L, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AASS!3", new DateTime(2020, 1, 31, 21, 23, 47, 12, DateTimeKind.Local), "PLN", 220m, 20m, null },
                    { 3L, new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AASS!4", new DateTime(2020, 1, 31, 21, 23, 47, 12, DateTimeKind.Local), "PLN", 110m, null, null },
                    { 4L, new DateTime(2015, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AASS!5", new DateTime(2020, 1, 31, 21, 23, 47, 12, DateTimeKind.Local), "PLN", 500m, null, null },
                    { 5L, new DateTime(2015, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AASS!6", new DateTime(2020, 1, 31, 21, 23, 47, 12, DateTimeKind.Local), "PLN", 532m, 102m, null },
                    { 6L, new DateTime(2017, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AASS!7", new DateTime(2020, 1, 31, 21, 23, 47, 12, DateTimeKind.Local), "PLN", 708m, 44m, null }
                });

            migrationBuilder.InsertData(
                table: "GuestReservations",
                columns: new[] { "Id", "GuestId", "ReservationId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L },
                    { 5L, 4L, 1L },
                    { 6L, 2L, 1L },
                    { 2L, 1L, 2L },
                    { 3L, 3L, 2L },
                    { 4L, 2L, 2L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GuestReservations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "GuestReservations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "GuestReservations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "GuestReservations",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "GuestReservations",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "GuestReservations",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
