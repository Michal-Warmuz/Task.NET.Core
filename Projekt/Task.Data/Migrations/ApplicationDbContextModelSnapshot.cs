﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task.Data;

namespace Task.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Task.Core.Domain.Guest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<string>("ZIP");

                    b.HasKey("Id");

                    b.ToTable("Guests");

                    b.HasData(
                        new { Id = 1L, Email = "jan@wp.pl", FirstName = "Jan", LastName = "Nowak", ZIP = "12-123" },
                        new { Id = 2L, Email = "janusz@wp.pl", FirstName = "Janusz", LastName = "Nowakowski", ZIP = "42-123" },
                        new { Id = 3L, Email = "kamila@wp.pl", FirstName = "Kamila", LastName = "Seweryn", ZIP = "33-133" },
                        new { Id = 4L, Email = "ola@wp.pl", FirstName = "Ola", LastName = "Nacht" }
                    );
                });

            modelBuilder.Entity("Task.Core.Domain.GuestReservation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GuestId");

                    b.Property<long>("ReservationId");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("ReservationId");

                    b.ToTable("GuestReservations");

                    b.HasData(
                        new { Id = 1L, GuestId = 1L, ReservationId = 1L },
                        new { Id = 2L, GuestId = 1L, ReservationId = 2L },
                        new { Id = 3L, GuestId = 3L, ReservationId = 2L },
                        new { Id = 4L, GuestId = 2L, ReservationId = 2L },
                        new { Id = 5L, GuestId = 4L, ReservationId = 1L },
                        new { Id = 6L, GuestId = 2L, ReservationId = 1L }
                    );
                });

            modelBuilder.Entity("Task.Core.Domain.Reservation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CheckInDate");

                    b.Property<DateTime>("CheckOutDate");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Currency")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<decimal?>("Provision");

                    b.Property<string>("Source");

                    b.HasKey("Id");

                    b.ToTable("Reservations");

                    b.HasData(
                        new { Id = 1L, CheckInDate = new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), CheckOutDate = new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), Code = "AASS!2", CreatedAt = new DateTime(2020, 1, 31, 21, 28, 3, 70, DateTimeKind.Local), Currency = "PLN", Price = 345m },
                        new { Id = 2L, CheckInDate = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), CheckOutDate = new DateTime(2019, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), Code = "AASS!3", CreatedAt = new DateTime(2020, 1, 31, 21, 28, 3, 72, DateTimeKind.Local), Currency = "PLN", Price = 220m, Provision = 20m },
                        new { Id = 3L, CheckInDate = new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), CheckOutDate = new DateTime(2019, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), Code = "AASS!4", CreatedAt = new DateTime(2020, 1, 31, 21, 28, 3, 72, DateTimeKind.Local), Currency = "PLN", Price = 110m },
                        new { Id = 4L, CheckInDate = new DateTime(2015, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), CheckOutDate = new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), Code = "AASS!5", CreatedAt = new DateTime(2020, 1, 31, 21, 28, 3, 72, DateTimeKind.Local), Currency = "PLN", Price = 500m },
                        new { Id = 5L, CheckInDate = new DateTime(2015, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), CheckOutDate = new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), Code = "AASS!6", CreatedAt = new DateTime(2020, 1, 31, 21, 28, 3, 72, DateTimeKind.Local), Currency = "PLN", Price = 532m, Provision = 102m },
                        new { Id = 6L, CheckInDate = new DateTime(2017, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), CheckOutDate = new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), Code = "AASS!7", CreatedAt = new DateTime(2020, 1, 31, 21, 28, 3, 72, DateTimeKind.Local), Currency = "PLN", Price = 708m, Provision = 44m }
                    );
                });

            modelBuilder.Entity("Task.Core.Domain.GuestReservation", b =>
                {
                    b.HasOne("Task.Core.Domain.Guest", "Guest")
                        .WithMany("GuestReservations")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Task.Core.Domain.Reservation", "Reservation")
                        .WithMany("GuestReservations")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
