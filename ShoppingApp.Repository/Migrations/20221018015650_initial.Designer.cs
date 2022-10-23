﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingApp.Repository;

#nullable disable

namespace ShoppingApp.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221018015650_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShoppingApp.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kırtasiye"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Elektronik"
                        });
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Kalem",
                            Price = 10
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Kalemlik",
                            Price = 10
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Name = "Bilgisayar",
                            Price = 1000
                        });
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.ProductOfList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingListId");

                    b.ToTable("ProductOfList");
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.ShoppingList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UserSegment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("UserSegment").HasValue("User");
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.AdminUser", b =>
                {
                    b.HasBaseType("ShoppingApp.Core.Models.User");

                    b.HasDiscriminator().HasValue("Admin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "onurcan@gmail.com",
                            Name = "Onur",
                            Password = "123a4b",
                            Surname = "Tasbas",
                            UserName = "healpls"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Ahaan@gmail.com",
                            Name = "Ahmet",
                            Password = "123a4b222",
                            Surname = "asdad",
                            UserName = "healpls11"
                        },
                        new
                        {
                            Id = 3,
                            Email = "n@gmail.com",
                            Name = "Ahmet11",
                            Password = "14b222",
                            Surname = "DKAAKA",
                            UserName = "hls11"
                        });
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.BasicUser", b =>
                {
                    b.HasBaseType("ShoppingApp.Core.Models.User");

                    b.HasDiscriminator().HasValue("Basic");
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.Product", b =>
                {
                    b.HasOne("ShoppingApp.Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.ProductOfList", b =>
                {
                    b.HasOne("ShoppingApp.Core.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoppingApp.Core.Models.ShoppingList", "ShoppingList")
                        .WithMany("Products")
                        .HasForeignKey("ShoppingListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingList");
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.ShoppingList", b =>
                {
                    b.HasOne("ShoppingApp.Core.Models.User", "User")
                        .WithMany("ShoppingLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.ShoppingList", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShoppingApp.Core.Models.User", b =>
                {
                    b.Navigation("ShoppingLists");
                });
#pragma warning restore 612, 618
        }
    }
}
