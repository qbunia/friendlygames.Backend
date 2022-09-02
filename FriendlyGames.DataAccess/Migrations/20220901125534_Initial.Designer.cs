﻿// <auto-generated />
using System;
using FriendlyGames.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FriendlyGames.DataAccess.Migrations
{
    [DbContext(typeof(FriendlyGamesDbContext))]
    [Migration("20220901125534_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FriendlyGames.Domain.Categories.EventCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EventCategoryImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EventCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EventCategoryImage = "ball-of-basketball.png",
                            Name = "Koszykówka"
                        },
                        new
                        {
                            Id = 2,
                            EventCategoryImage = "football.png",
                            Name = "Piłka Nożna"
                        },
                        new
                        {
                            Id = 3,
                            EventCategoryImage = "dumbbell.png",
                            Name = "Siłownia"
                        },
                        new
                        {
                            Id = 4,
                            EventCategoryImage = "running.png",
                            Name = "Bieganie"
                        },
                        new
                        {
                            Id = 5,
                            EventCategoryImage = "bicycle.png",
                            Name = "Rower"
                        },
                        new
                        {
                            Id = 6,
                            EventCategoryImage = "siatkowka.png",
                            Name = "Siatkówka"
                        },
                        new
                        {
                            Id = 7,
                            EventCategoryImage = "tennis.png",
                            Name = "Tenis"
                        },
                        new
                        {
                            Id = 8,
                            EventCategoryImage = "table-tennis.png",
                            Name = "Ping Pong"
                        },
                        new
                        {
                            Id = 9,
                            EventCategoryImage = "bowling.png",
                            Name = "Kręgielnia"
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Enums.LevelCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LevelCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Łatwy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Średni"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Zaawanzowany"
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Enums.RegistrationCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RegistrationCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Oczekujące"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Zaakceptowane"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Odrzucone"
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Enums.SurfaceCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurfaceCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Trawa"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kort"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Piasek"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hala"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Basen"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Syntetyczna"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Inne"
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Enums.SurroundingCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurroundingCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Węwnątrz"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Na zewnątrz"
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageForEvent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LevelCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("MaxNumberOfPlayers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PriceForEvent")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SurfaceCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SurroundingCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("EventCategoryId");

                    b.HasIndex("LevelCategoryId");

                    b.HasIndex("SurfaceCategoryId");

                    b.HasIndex("SurroundingCategoryId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Tarnów",
                            CreatorId = 1,
                            Description = "Szukam osób do gry w kosza",
                            EndDateTime = new DateTime(2022, 8, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            EventCategoryId = 1,
                            ImageForEvent = "basketball-box.png",
                            LevelCategoryId = 2,
                            MaxNumberOfPlayers = 8,
                            Name = "Koszykówka",
                            PriceForEvent = 30.0,
                            StartDateTime = new DateTime(2022, 8, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Street = "Piłsudskiego 24",
                            SurfaceCategoryId = 6,
                            SurroundingCategoryId = 2
                        },
                        new
                        {
                            Id = 2,
                            City = "Kraków",
                            CreatorId = 2,
                            Description = "Orlikowe granie",
                            EndDateTime = new DateTime(2022, 8, 1, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            EventCategoryId = 2,
                            ImageForEvent = "footbal-box.png",
                            LevelCategoryId = 1,
                            MaxNumberOfPlayers = 10,
                            Name = "Piłka Nożna",
                            PriceForEvent = 0.0,
                            StartDateTime = new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Street = "Grzegórzecka 24",
                            SurfaceCategoryId = 1,
                            SurroundingCategoryId = 2
                        },
                        new
                        {
                            Id = 3,
                            City = "Żywiec",
                            CreatorId = 3,
                            Description = "Ciężki trening",
                            EndDateTime = new DateTime(2022, 8, 1, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            EventCategoryId = 3,
                            ImageForEvent = "footbal-box.png",
                            LevelCategoryId = 2,
                            MaxNumberOfPlayers = 10,
                            Name = "Siłownia",
                            PriceForEvent = 0.0,
                            StartDateTime = new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Street = "Kazimierza Tetmajera 75",
                            SurfaceCategoryId = 3,
                            SurroundingCategoryId = 2
                        },
                        new
                        {
                            Id = 4,
                            City = "Wrocław",
                            CreatorId = 4,
                            Description = "Sprinty na 200m",
                            EndDateTime = new DateTime(2022, 8, 1, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            EventCategoryId = 4,
                            ImageForEvent = "footbal-box.png",
                            LevelCategoryId = 3,
                            MaxNumberOfPlayers = 3,
                            Name = "Bieganie",
                            PriceForEvent = 0.0,
                            StartDateTime = new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Street = "Różanka",
                            SurfaceCategoryId = 7,
                            SurroundingCategoryId = 2
                        },
                        new
                        {
                            Id = 5,
                            City = "Szczecin",
                            CreatorId = 5,
                            Description = "Nauka jazdy na jednym kole",
                            EndDateTime = new DateTime(2022, 8, 1, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            EventCategoryId = 5,
                            ImageForEvent = "footbal-box.png",
                            LevelCategoryId = 2,
                            MaxNumberOfPlayers = 15,
                            Name = "Rower",
                            PriceForEvent = 10.0,
                            StartDateTime = new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Street = "Modra 104",
                            SurfaceCategoryId = 7,
                            SurroundingCategoryId = 2
                        },
                        new
                        {
                            Id = 6,
                            City = "Warszawa",
                            CreatorId = 6,
                            Description = "Sobotni chill",
                            EndDateTime = new DateTime(2022, 8, 1, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            EventCategoryId = 9,
                            ImageForEvent = "footbal-box.png",
                            LevelCategoryId = 1,
                            MaxNumberOfPlayers = 4,
                            Name = "Kręgle",
                            PriceForEvent = 16.0,
                            StartDateTime = new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Street = "Vincenta van Gogha 1",
                            SurfaceCategoryId = 4,
                            SurroundingCategoryId = 1
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.Registration", b =>
                {
                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RegistrationCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("EventId", "UserId");

                    b.HasIndex("RegistrationCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Registrations");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            UserId = 1,
                            RegistrationCategoryId = 1,
                            RegistrationDateTime = new DateTime(2022, 9, 1, 14, 55, 33, 991, DateTimeKind.Local).AddTicks(1299)
                        },
                        new
                        {
                            EventId = 1,
                            UserId = 2,
                            RegistrationCategoryId = 1,
                            RegistrationDateTime = new DateTime(2022, 9, 1, 14, 55, 33, 991, DateTimeKind.Local).AddTicks(1413)
                        },
                        new
                        {
                            EventId = 2,
                            UserId = 2,
                            RegistrationCategoryId = 2,
                            RegistrationDateTime = new DateTime(2022, 9, 1, 14, 55, 33, 991, DateTimeKind.Local).AddTicks(1427)
                        },
                        new
                        {
                            EventId = 2,
                            UserId = 1,
                            RegistrationCategoryId = 3,
                            RegistrationDateTime = new DateTime(2022, 9, 1, 14, 55, 33, 991, DateTimeKind.Local).AddTicks(1441)
                        },
                        new
                        {
                            EventId = 3,
                            UserId = 3,
                            RegistrationCategoryId = 2,
                            RegistrationDateTime = new DateTime(2022, 9, 1, 14, 55, 33, 991, DateTimeKind.Local).AddTicks(1453)
                        },
                        new
                        {
                            EventId = 4,
                            UserId = 4,
                            RegistrationCategoryId = 2,
                            RegistrationDateTime = new DateTime(2022, 9, 1, 14, 55, 33, 991, DateTimeKind.Local).AddTicks(1500)
                        },
                        new
                        {
                            EventId = 5,
                            UserId = 5,
                            RegistrationCategoryId = 2,
                            RegistrationDateTime = new DateTime(2022, 9, 1, 14, 55, 33, 991, DateTimeKind.Local).AddTicks(1512)
                        },
                        new
                        {
                            EventId = 6,
                            UserId = 6,
                            RegistrationCategoryId = 2,
                            RegistrationDateTime = new DateTime(2022, 9, 1, 14, 55, 33, 991, DateTimeKind.Local).AddTicks(1524)
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Adam",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Franek",
                            LastName = "Stopka"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Asia",
                            LastName = "Szul"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Tomek",
                            LastName = "Broda"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Grzegorz",
                            LastName = "Wisła"
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.Event", b =>
                {
                    b.HasOne("FriendlyGames.Domain.Models.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FriendlyGames.Domain.Categories.EventCategory", "EventCategory")
                        .WithMany()
                        .HasForeignKey("EventCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FriendlyGames.Domain.Enums.LevelCategory", "LevelCategory")
                        .WithMany()
                        .HasForeignKey("LevelCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FriendlyGames.Domain.Enums.SurfaceCategory", "SurfaceCategory")
                        .WithMany()
                        .HasForeignKey("SurfaceCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FriendlyGames.Domain.Enums.SurroundingCategory", "SurroundingCategory")
                        .WithMany()
                        .HasForeignKey("SurroundingCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("EventCategory");

                    b.Navigation("LevelCategory");

                    b.Navigation("SurfaceCategory");

                    b.Navigation("SurroundingCategory");
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.Registration", b =>
                {
                    b.HasOne("FriendlyGames.Domain.Models.Event", "Event")
                        .WithMany("Registrations")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FriendlyGames.Domain.Enums.RegistrationCategory", "RegistrationCategory")
                        .WithMany()
                        .HasForeignKey("RegistrationCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FriendlyGames.Domain.Models.User", "User")
                        .WithMany("Registrations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("RegistrationCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.Event", b =>
                {
                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.User", b =>
                {
                    b.Navigation("Registrations");
                });
#pragma warning restore 612, 618
        }
    }
}