﻿// <auto-generated />
using System;
using Lumina_Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Lumina_Backend.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240410212742_Test")]
    partial class Test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Lumina_Backend.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountNumber")
                        .HasColumnType("integer");

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Accounts", (string)null);
                });

            modelBuilder.Entity("Lumina_Backend.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Action")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Logs", (string)null);
                });

            modelBuilder.Entity("Lumina_Backend.Models.Security", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SecurityAnswers")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SecurityQuestions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Securities", (string)null);
                });

            modelBuilder.Entity("Lumina_Backend.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountID")
                        .HasColumnType("integer");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("TransactionDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AccountID");

                    b.ToTable("Transactions", (string)null);
                });

            modelBuilder.Entity("Lumina_Backend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("DNI")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("text");

                    b.Property<string>("SessionToken")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -1,
                            DateAdded = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7097),
                            DateOfBirth = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7100),
                            DateUpdated = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7100),
                            Email = "ajruiz2204@example.com",
                            Password = "123456",
                            Status = 0,
                            UserName = "ajruiz2204"
                        },
                        new
                        {
                            Id = -2,
                            DateAdded = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7108),
                            DateOfBirth = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7108),
                            DateUpdated = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7108),
                            Email = "4rnol@example.com",
                            Password = "123456",
                            Status = 0,
                            UserName = "4rnol"
                        },
                        new
                        {
                            Id = -3,
                            DateAdded = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7110),
                            DateOfBirth = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7110),
                            DateUpdated = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7110),
                            Email = "alexanderfrt@example.com",
                            Password = "123456",
                            Status = 0,
                            UserName = "AlexanderFRT"
                        },
                        new
                        {
                            Id = -4,
                            DateAdded = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7111),
                            DateOfBirth = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7112),
                            DateUpdated = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7112),
                            Email = "ezealeguzman@example.com",
                            Password = "123456",
                            Status = 0,
                            UserName = "ezealeguzman"
                        },
                        new
                        {
                            Id = -5,
                            DateAdded = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7113),
                            DateOfBirth = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7113),
                            DateUpdated = new DateTime(2024, 4, 10, 21, 27, 42, 391, DateTimeKind.Utc).AddTicks(7113),
                            Email = "giolucc@example.com",
                            Password = "123456",
                            Status = 0,
                            UserName = "giolucc"
                        });
                });

            modelBuilder.Entity("Lumina_Backend.Models.Account", b =>
                {
                    b.HasOne("Lumina_Backend.Models.User", "User")
                        .WithMany("Accounts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Lumina_Backend.Models.Log", b =>
                {
                    b.HasOne("Lumina_Backend.Models.User", "User")
                        .WithMany("Logs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Lumina_Backend.Models.Security", b =>
                {
                    b.HasOne("Lumina_Backend.Models.User", "User")
                        .WithMany("Securities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Lumina_Backend.Models.Transaction", b =>
                {
                    b.HasOne("Lumina_Backend.Models.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Lumina_Backend.Models.Account", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Lumina_Backend.Models.User", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Logs");

                    b.Navigation("Securities");
                });
#pragma warning restore 612, 618
        }
    }
}
