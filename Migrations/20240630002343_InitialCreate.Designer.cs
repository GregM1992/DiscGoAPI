﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DiscGoAPI.Migrations
{
    [DbContext(typeof(DiscGoAPIDbContext))]
    [Migration("20240630002343_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DiscGoAPI.Models.Bag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BagName")
                        .HasColumnType("text");

                    b.Property<bool>("Favorite")
                        .HasColumnType("boolean");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Bags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BagName = "FavoriteBag",
                            Favorite = true,
                            UserId = "OTSAVyBcQ5R8N7OeGx6sHDr4RV53"
                        },
                        new
                        {
                            Id = 2,
                            BagName = "notFavorite",
                            Favorite = false,
                            UserId = "OTSAVyBcQ5R8N7OeGx6sHDr4RV53"
                        });
                });

            modelBuilder.Entity("DiscGoAPI.Models.BaggedDisc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BagId")
                        .HasColumnType("integer");

                    b.Property<int>("Birdies")
                        .HasColumnType("integer");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<int>("Fade")
                        .HasColumnType("integer");

                    b.Property<int>("Glide")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Speed")
                        .HasColumnType("integer");

                    b.Property<string>("Stability")
                        .HasColumnType("text");

                    b.Property<int>("Turn")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("BaggedDiscs");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            BagId = 1,
                            Birdies = 3,
                            Brand = "axiom",
                            Category = "putter",
                            Color = "#343403",
                            Fade = 3,
                            Glide = 3,
                            Name = "roc",
                            Speed = 3,
                            Stability = "over-stable",
                            Turn = 3
                        });
                });

            modelBuilder.Entity("DiscGoAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "myEmail.com",
                            UserId = "OTSAVyBcQ5R8N7OeGx6sHDr4RV53",
                            UserName = "discGuy32"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
