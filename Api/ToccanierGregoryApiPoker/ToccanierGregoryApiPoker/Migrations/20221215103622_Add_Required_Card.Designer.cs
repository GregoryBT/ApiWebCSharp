﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToccanierGregoryApiPoker.Context;

#nullable disable

namespace ToccanierGregoryApiPoker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221215103622_Add_Required_Card")]
    partial class AddRequiredCard
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ToccanierGregoryApiPoker.Entity.Card", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("couleur")
                        .IsRequired()
                        .HasColumnType("ENUM(\"Trèfle\", \"Carreau\", \"Coeur\", \"Pique\")");

                    b.Property<int?>("game_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("ENUM(\"As\", \"Deux\", \"Trois\", \"Quatre\", \"Cinq\", \"Six\", \"Sept\", \"Huit\", \"Neuf\", \"Dix\", \"Valet\", \"Dame\", \"Roi\")");

                    b.Property<int?>("player_id")
                        .HasColumnType("int");

                    b.Property<string>("symbole")
                        .IsRequired()
                        .HasColumnType("ENUM(\"A\", \"2\", \"3\", \"4\", \"5\", \"6\", \"7\", \"8\", \"9\", \"10\", \"J\", \"Q\", \"K\")");

                    b.Property<int?>("values")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("game_id");

                    b.HasIndex("player_id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("ToccanierGregoryApiPoker.Entity.Game", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("buy_in")
                        .HasColumnType("int");

                    b.Property<DateTime?>("end_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("max_players")
                        .HasColumnType("int");

                    b.Property<int?>("nb_turn")
                        .HasColumnType("int");

                    b.Property<int?>("pot")
                        .HasColumnType("int");

                    b.Property<DateTime?>("start_date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("ToccanierGregoryApiPoker.Entity.Player", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("game_id")
                        .HasColumnType("int");

                    b.Property<int?>("money")
                        .HasColumnType("int");

                    b.Property<int?>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("game_id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("ToccanierGregoryApiPoker.Entity.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("birth_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("money")
                        .HasColumnType("int");

                    b.Property<int?>("nb_games")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("username")
                        .HasColumnType("Varchar(30)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ToccanierGregoryApiPoker.Entity.Card", b =>
                {
                    b.HasOne("ToccanierGregoryApiPoker.Entity.Game", "game")
                        .WithMany("card")
                        .HasForeignKey("game_id");

                    b.HasOne("ToccanierGregoryApiPoker.Entity.Player", "player")
                        .WithMany("card")
                        .HasForeignKey("player_id");

                    b.Navigation("game");

                    b.Navigation("player");
                });

            modelBuilder.Entity("ToccanierGregoryApiPoker.Entity.Player", b =>
                {
                    b.HasOne("ToccanierGregoryApiPoker.Entity.Game", "game")
                        .WithMany("player")
                        .HasForeignKey("game_id");

                    b.HasOne("ToccanierGregoryApiPoker.Entity.User", "user")
                        .WithOne("player")
                        .HasForeignKey("ToccanierGregoryApiPoker.Entity.Player", "user_id");

                    b.Navigation("game");

                    b.Navigation("user");
                });

            modelBuilder.Entity("ToccanierGregoryApiPoker.Entity.Game", b =>
                {
                    b.Navigation("card");

                    b.Navigation("player");
                });

            modelBuilder.Entity("ToccanierGregoryApiPoker.Entity.Player", b =>
                {
                    b.Navigation("card");
                });

            modelBuilder.Entity("ToccanierGregoryApiPoker.Entity.User", b =>
                {
                    b.Navigation("player");
                });
#pragma warning restore 612, 618
        }
    }
}