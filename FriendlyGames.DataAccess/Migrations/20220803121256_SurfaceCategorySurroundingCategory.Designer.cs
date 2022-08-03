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
    [Migration("20220803121256_SurfaceCategorySurroundingCategory")]
    partial class SurfaceCategorySurroundingCategory
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

                    b.Property<string>("Description")
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
                            Description = "Biegi krótkie, długie i takie sobie...",
                            Name = "Bieg"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Nic się nie stało, rodacy nic się nie stało",
                            Name = "Mecz piłki nożnej"
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
                            Name = "Easy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Advanced"
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
                            Name = "Waiting"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Accepted"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rejected"
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
                            Name = "Grass"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Court"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sand"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hall"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pool"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Others"
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
                            Name = "Indoor"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("LevelCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

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
                            CreatorId = 1,
                            EndDateTime = new DateTime(2022, 8, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            EventCategoryId = 1,
                            LevelCategoryId = 2,
                            Name = "Runmageddon",
                            StartDateTime = new DateTime(2022, 8, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            SurfaceCategoryId = 1,
                            SurroundingCategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatorId = 2,
                            EndDateTime = new DateTime(2022, 8, 1, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            EventCategoryId = 2,
                            LevelCategoryId = 1,
                            Name = "My kontra Wy",
                            StartDateTime = new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            SurfaceCategoryId = 1,
                            SurroundingCategoryId = 2
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.FootballMatch", b =>
                {
                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("TeamAId")
                        .HasColumnType("int");

                    b.Property<int>("TeamBId")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.HasIndex("TeamAId");

                    b.HasIndex("TeamBId");

                    b.ToTable("FootballMatches");

                    b.HasData(
                        new
                        {
                            EventId = 2,
                            Id = 1,
                            TeamAId = 1,
                            TeamBId = 2
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nickname = "JD",
                            TeamId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Nickname = "AS",
                            TeamId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Nickname = "DJ",
                            TeamId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Nickname = "SA",
                            TeamId = 2,
                            UserId = 2
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
                            RegistrationDateTime = new DateTime(2022, 8, 3, 14, 12, 56, 431, DateTimeKind.Local).AddTicks(1642)
                        },
                        new
                        {
                            EventId = 1,
                            UserId = 2,
                            RegistrationCategoryId = 1,
                            RegistrationDateTime = new DateTime(2022, 8, 3, 14, 12, 56, 431, DateTimeKind.Local).AddTicks(1703)
                        },
                        new
                        {
                            EventId = 2,
                            UserId = 2,
                            RegistrationCategoryId = 2,
                            RegistrationDateTime = new DateTime(2022, 8, 3, 14, 12, 56, 431, DateTimeKind.Local).AddTicks(1716)
                        },
                        new
                        {
                            EventId = 2,
                            UserId = 1,
                            RegistrationCategoryId = 3,
                            RegistrationDateTime = new DateTime(2022, 8, 3, 14, 12, 56, 431, DateTimeKind.Local).AddTicks(1730)
                        });
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "My"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Wy"
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

            modelBuilder.Entity("FriendlyGames.Domain.Models.FootballMatch", b =>
                {
                    b.HasOne("FriendlyGames.Domain.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FriendlyGames.Domain.Models.Team", "TeamA")
                        .WithMany("MatchesA")
                        .HasForeignKey("TeamAId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FriendlyGames.Domain.Models.Team", "TeamB")
                        .WithMany("MatchesB")
                        .HasForeignKey("TeamBId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("TeamA");

                    b.Navigation("TeamB");
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.Player", b =>
                {
                    b.HasOne("FriendlyGames.Domain.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FriendlyGames.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");

                    b.Navigation("User");
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

            modelBuilder.Entity("FriendlyGames.Domain.Models.Team", b =>
                {
                    b.Navigation("MatchesA");

                    b.Navigation("MatchesB");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("FriendlyGames.Domain.Models.User", b =>
                {
                    b.Navigation("Registrations");
                });
#pragma warning restore 612, 618
        }
    }
}
