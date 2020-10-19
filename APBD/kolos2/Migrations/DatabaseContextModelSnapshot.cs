﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kolos2.Models;

namespace kolos2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("kolos2.Models.Championship", b =>
                {
                    b.Property<int>("IdChampionship")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OfficialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("IdChampionship")
                        .HasName("IdChampionship");

                    b.ToTable("Championship");

                    b.HasData(
                        new
                        {
                            IdChampionship = 1,
                            OfficialName = "LM",
                            Year = 2019
                        },
                        new
                        {
                            IdChampionship = 2,
                            OfficialName = "LMS",
                            Year = 2020
                        });
                });

            modelBuilder.Entity("kolos2.Models.Championship_Team", b =>
                {
                    b.Property<int>("IdChampionshipTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdChampionship")
                        .HasColumnType("int");

                    b.Property<int>("IdTeam")
                        .HasColumnType("int");

                    b.Property<float?>("Score")
                        .HasColumnType("real");

                    b.HasKey("IdChampionshipTeam")
                        .HasName("IdChampionshipTeam");

                    b.HasIndex("IdChampionship");

                    b.HasIndex("IdTeam");

                    b.ToTable("Championship_Team");

                    b.HasData(
                        new
                        {
                            IdChampionshipTeam = 1,
                            IdChampionship = 1,
                            IdTeam = 1,
                            Score = 5f
                        },
                        new
                        {
                            IdChampionshipTeam = 2,
                            IdChampionship = 1,
                            IdTeam = 2,
                            Score = 3f
                        },
                        new
                        {
                            IdChampionshipTeam = 3,
                            IdChampionship = 2,
                            IdTeam = 1,
                            Score = 3f
                        },
                        new
                        {
                            IdChampionshipTeam = 4,
                            IdChampionship = 2,
                            IdTeam = 2,
                            Score = 5f
                        });
                });

            modelBuilder.Entity("kolos2.Models.Player", b =>
                {
                    b.Property<int>("IdPlayer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdPlayer")
                        .HasName("IdPlayer");

                    b.ToTable("Player");

                    b.HasData(
                        new
                        {
                            IdPlayer = 1,
                            DateOfBirth = new DateTime(1997, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jan",
                            LastName = "Biniek"
                        },
                        new
                        {
                            IdPlayer = 2,
                            DateOfBirth = new DateTime(1997, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kuba",
                            LastName = "Adamczyk"
                        },
                        new
                        {
                            IdPlayer = 3,
                            DateOfBirth = new DateTime(1997, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kacper",
                            LastName = "Urbański"
                        },
                        new
                        {
                            IdPlayer = 4,
                            DateOfBirth = new DateTime(1997, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Rafał",
                            LastName = "Piórek"
                        });
                });

            modelBuilder.Entity("kolos2.Models.Player_Team", b =>
                {
                    b.Property<int>("IdPlayerTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPlayer")
                        .HasColumnType("int");

                    b.Property<int>("IdTeam")
                        .HasColumnType("int");

                    b.Property<int>("NumOnShirt")
                        .HasColumnType("int")
                        .HasMaxLength(300);

                    b.HasKey("IdPlayerTeam")
                        .HasName("IdPlayerTeam");

                    b.HasIndex("IdPlayer");

                    b.HasIndex("IdTeam");

                    b.ToTable("Player_Team");

                    b.HasData(
                        new
                        {
                            IdPlayerTeam = 1,
                            Comment = "mlody",
                            IdPlayer = 1,
                            IdTeam = 1,
                            NumOnShirt = 1
                        },
                        new
                        {
                            IdPlayerTeam = 2,
                            Comment = "stary",
                            IdPlayer = 2,
                            IdTeam = 1,
                            NumOnShirt = 2
                        },
                        new
                        {
                            IdPlayerTeam = 3,
                            Comment = "mlody",
                            IdPlayer = 3,
                            IdTeam = 2,
                            NumOnShirt = 1
                        },
                        new
                        {
                            IdPlayerTeam = 4,
                            Comment = "stary",
                            IdPlayer = 4,
                            IdTeam = 2,
                            NumOnShirt = 2
                        });
                });

            modelBuilder.Entity("kolos2.Models.Team", b =>
                {
                    b.Property<int>("IdTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxAge")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("IdTeam")
                        .HasName("IdTeam");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            IdTeam = 1,
                            MaxAge = 30,
                            TeamName = "Groove"
                        },
                        new
                        {
                            IdTeam = 2,
                            MaxAge = 30,
                            TeamName = "Beksy"
                        });
                });

            modelBuilder.Entity("kolos2.Models.Championship_Team", b =>
                {
                    b.HasOne("kolos2.Models.Championship", "Championship")
                        .WithMany("championship_Teams")
                        .HasForeignKey("IdChampionship")
                        .HasConstraintName("Championship_Team_Championship")
                        .IsRequired();

                    b.HasOne("kolos2.Models.Team", "Team")
                        .WithMany("championship_Teams")
                        .HasForeignKey("IdTeam")
                        .HasConstraintName("Championship_Team_Team")
                        .IsRequired();
                });

            modelBuilder.Entity("kolos2.Models.Player_Team", b =>
                {
                    b.HasOne("kolos2.Models.Player", "Player")
                        .WithMany("player_Teams")
                        .HasForeignKey("IdPlayer")
                        .HasConstraintName("Player_Team_Player")
                        .IsRequired();

                    b.HasOne("kolos2.Models.Team", "Team")
                        .WithMany("player_Teams")
                        .HasForeignKey("IdTeam")
                        .HasConstraintName("Player_Team_Team")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
