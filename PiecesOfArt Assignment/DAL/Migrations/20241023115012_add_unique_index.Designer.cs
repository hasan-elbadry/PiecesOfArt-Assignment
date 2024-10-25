﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PiecesOfArt_Assignment.DAL.Data;


#nullable disable

namespace PiecesOfArt_Assignment.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241023115012_add_unique_index")]
    partial class add_unique_index
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PiecesOfArt_Assignment.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(170)
                        .HasColumnType("nvarchar(170)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(170)
                        .HasColumnType("nvarchar(170)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A 19th-century art movement characterized by small.",
                            Name = "Impressionism"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A period in European history and wisdom.",
                            Name = "Renaissance"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Art that uses shapes.",
                            Name = "Abstract"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A broad category during the late 19th to mid-20th century.",
                            Name = "Modern"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Art from ancient, Mesopotamian, and classical Greek.",
                            Name = "Ancient"
                        });
                });

            modelBuilder.Entity("PiecesOfArt_Assignment.Models.LoyaltyCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(170)
                        .HasColumnType("nvarchar(170)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(170)
                        .HasColumnType("nvarchar(170)");

                    b.HasKey("Id");

                    b.ToTable("LoyaltyCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "10% Off",
                            Name = "Bronze"
                        },
                        new
                        {
                            Id = 2,
                            Description = "20% Off",
                            Name = "Silver"
                        },
                        new
                        {
                            Id = 3,
                            Description = "30% Off",
                            Name = "Gold"
                        },
                        new
                        {
                            Id = 4,
                            Description = "40% Off",
                            Name = "Platinum"
                        },
                        new
                        {
                            Id = 5,
                            Description = "50% Off",
                            Name = "Crystal"
                        });
                });

            modelBuilder.Entity("PiecesOfArt_Assignment.Models.PieceOfArt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasMaxLength(170)
                        .HasColumnType("float");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(170)
                        .HasColumnType("nvarchar(170)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("PieceOfArts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Price = 100000.0,
                            PublicationDate = new DateTime(1889, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Starry Night",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Price = 500000.0,
                            PublicationDate = new DateTime(1503, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Mona Lisa",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Price = 120000.0,
                            PublicationDate = new DateTime(1923, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Composition VIII",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("PiecesOfArt_Assignment.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(170)
                        .HasColumnType("nvarchar(170)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(170)
                        .HasColumnType("nvarchar(170)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("loyaltyCardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("loyaltyCardId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 28,
                            Email = "alice.johnson@example.com",
                            Name = "Alice Johnson",
                            Password = "SecurePassword123!",
                            loyaltyCardId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 35,
                            Email = "bob.smith@example.com",
                            Name = "Bob Smith",
                            Password = "Password456!",
                            loyaltyCardId = 2
                        },
                        new
                        {
                            Id = 3,
                            Age = 42,
                            Email = "charlie.brown@example.com",
                            Name = "Charlie Brown",
                            Password = "Passw0rd789!",
                            loyaltyCardId = 3
                        },
                        new
                        {
                            Id = 4,
                            Age = 30,
                            Email = "diana.prince@example.com",
                            Name = "Diana Prince",
                            Password = "WonderWoman321!",
                            loyaltyCardId = 4
                        },
                        new
                        {
                            Id = 5,
                            Age = 38,
                            Email = "edward.nygma@example.com",
                            Name = "Edward Nygma",
                            Password = "RiddleMeThis456!",
                            loyaltyCardId = 5
                        });
                });

            modelBuilder.Entity("PiecesOfArt_Assignment.Models.PieceOfArt", b =>
                {
                    b.HasOne("PiecesOfArt_Assignment.Models.Category", "Category")
                        .WithMany("PieceOfArts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PiecesOfArt_Assignment.Models.User", "User")
                        .WithMany("PieceOfArts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PiecesOfArt_Assignment.Models.User", b =>
                {
                    b.HasOne("PiecesOfArt_Assignment.Models.LoyaltyCard", "LoyaltyCard")
                        .WithMany("Users")
                        .HasForeignKey("loyaltyCardId");

                    b.Navigation("LoyaltyCard");
                });

            modelBuilder.Entity("PiecesOfArt_Assignment.Models.Category", b =>
                {
                    b.Navigation("PieceOfArts");
                });

            modelBuilder.Entity("PiecesOfArt_Assignment.Models.LoyaltyCard", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("PiecesOfArt_Assignment.Models.User", b =>
                {
                    b.Navigation("PieceOfArts");
                });
#pragma warning restore 612, 618
        }
    }
}
