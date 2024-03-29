﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToccanierGregoryApiWeb.Context;

#nullable disable

namespace ToccanierGregoryApiWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221214141520_modifierlestables")]
    partial class modifierlestables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ToccanierGregoryApiWeb.Entity.Player", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("age")
                        .HasColumnType("longtext");

                    b.Property<string>("firstname")
                        .HasColumnType("longtext");

                    b.Property<string>("lastname")
                        .HasColumnType("longtext");

                    b.Property<int?>("money")
                        .HasColumnType("int");

                    b.Property<int?>("nbr_games")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("longtext");

                    b.Property<string>("username")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
