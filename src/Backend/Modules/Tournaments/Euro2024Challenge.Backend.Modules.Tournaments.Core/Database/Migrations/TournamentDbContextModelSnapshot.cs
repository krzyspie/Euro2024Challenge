﻿// <auto-generated />
using System;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.Database.Migrations
{
    [DbContext(typeof(TournamentDbContext))]
    partial class TournamentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("tournaments")
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities.Footballer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<int>("Golas")
                        .HasColumnType("integer");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Footballers", "tournaments");
                });

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AwayTeamGoals")
                        .HasColumnType("integer");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("integer");

                    b.Property<int>("GuestTeamGoals")
                        .HasColumnType("integer");

                    b.Property<int>("GuestTeamId")
                        .HasColumnType("integer");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartHour")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Matches", "tournaments");
                });

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Teams", "tournaments");
                });

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities.Footballer", b =>
                {
                    b.HasOne("Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities.Team", "Team")
                        .WithMany("Footballers")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities.Team", b =>
                {
                    b.Navigation("Footballers");
                });
#pragma warning restore 612, 618
        }
    }
}
