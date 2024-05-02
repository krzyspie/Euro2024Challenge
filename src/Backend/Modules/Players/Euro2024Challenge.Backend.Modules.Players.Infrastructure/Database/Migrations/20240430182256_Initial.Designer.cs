﻿// <auto-generated />
using System;
using Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Euro2024Challenge.Backend.Modules.Players.Infrastructure.Database.Migrations
{
    [DbContext(typeof(PlayersDbContext))]
    [Migration("20240430182256_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("players")
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.MatchBet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MatchId")
                        .HasColumnType("integer");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uuid");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("MatchBets", "players");
                });

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Players", "players");
                });

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.TopScorerBet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FootballerId")
                        .HasColumnType("integer");

                    b.Property<int>("Goals")
                        .HasColumnType("integer");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.ToTable("TopScorerBet", "players");
                });

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.TournamentWinnerBet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uuid");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.ToTable("TournamentWinnerBets", "players");
                });

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.MatchBet", b =>
                {
                    b.HasOne("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.Player", null)
                        .WithMany("MatchBets")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.TopScorerBet", b =>
                {
                    b.HasOne("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.Player", null)
                        .WithOne("TopScorerBet")
                        .HasForeignKey("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.TopScorerBet", "PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.TournamentWinnerBet", b =>
                {
                    b.HasOne("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.Player", null)
                        .WithOne("TournamentWinnerBet")
                        .HasForeignKey("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.TournamentWinnerBet", "PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Euro2024Challenge.Backend.Modules.Players.Domain.Entities.Player", b =>
                {
                    b.Navigation("MatchBets");

                    b.Navigation("TopScorerBet")
                        .IsRequired();

                    b.Navigation("TournamentWinnerBet")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
