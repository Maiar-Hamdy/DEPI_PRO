﻿// <auto-generated />
using System;
using Mailo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mailoo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mailo.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("userId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("userId");

                    b.ToTable("Contact", (string)null);
                });

            modelBuilder.Entity("Mailo.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal>("DeliveryFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("EmpID")
                        .HasColumnType("int");

                    b.Property<string>("OrderAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("decimal(18,2)")
                        .HasComputedColumnSql("[OrderPrice] + [DeliveryFee]");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EmpID");

                    b.HasIndex("UserID");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("Mailo.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderProduct", (string)null);
                });

            modelBuilder.Entity("Mailo.Models.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OrderID")
                        .IsUnique();

                    b.HasIndex("UserID");

                    b.ToTable("Payment", (string)null);
                });

            modelBuilder.Entity("Mailo.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AdditionDate")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("decimal(18,2)")
                        .HasComputedColumnSql("[Price]-([Discount]/100)*[Price]");

                    b.Property<byte[]>("dbImage")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ID");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AdditionDate = "20/11/2024 03:43:21 م",
                            Category = 1,
                            Discount = 10m,
                            ImageUrl = "~/images/sweet-shirt-girl.jpg",
                            Name = "Black Hoodi",
                            Price = 500m,
                            Quantity = 5,
                            TotalPrice = 0m
                        });
                });

            modelBuilder.Entity("Mailo.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)")
                        .HasComputedColumnSql("[FName] + ' ' + [LName]");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User", (string)null);

                    b.HasDiscriminator().HasValue("User");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            ID = 2,
                            Address = "Beni-Suef",
                            Email = "mailostoreee@gmail.com",
                            FName = "Mai",
                            Gender = 1,
                            LName = "Assem",
                            Password = "MaiiiAsss123#44",
                            PhoneNumber = "01011895030",
                            RegistrationDate = new DateTime(2024, 11, 20, 15, 43, 21, 903, DateTimeKind.Local).AddTicks(8769),
                            UserType = 1,
                            Username = "MaiAssemAdmin123"
                        });
                });

            modelBuilder.Entity("Mailo.Models.Wishlist", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("AdditionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("Wishlist", (string)null);
                });

            modelBuilder.Entity("Mailo.Models.Employee", b =>
                {
                    b.HasBaseType("Mailo.Models.User");

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Employee");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Beni-Suef",
                            Email = "Ahmedstoreee@gmail.com",
                            FName = "Ahmed",
                            Gender = 0,
                            LName = "Assem",
                            Password = "AhmedddAsss123#44",
                            PhoneNumber = "01011890000",
                            RegistrationDate = new DateTime(2024, 11, 20, 15, 43, 21, 903, DateTimeKind.Local).AddTicks(9034),
                            UserType = 2,
                            Username = "AhmedAssemAdmin123",
                            HiringDate = new DateTime(2024, 11, 20, 15, 43, 21, 903, DateTimeKind.Local).AddTicks(9028)
                        });
                });

            modelBuilder.Entity("Mailo.Models.Contact", b =>
                {
                    b.HasOne("Mailo.Models.User", "user")
                        .WithMany("Message")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("user");
                });

            modelBuilder.Entity("Mailo.Models.Order", b =>
                {
                    b.HasOne("Mailo.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("EmpID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Mailo.Models.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Mailo.Models.OrderProduct", b =>
                {
                    b.HasOne("Mailo.Models.Order", "order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Mailo.Models.Product", "product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("Mailo.Models.Payment", b =>
                {
                    b.HasOne("Mailo.Models.Order", "order")
                        .WithOne("Payment")
                        .HasForeignKey("Mailo.Models.Payment", "OrderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Mailo.Models.User", "user")
                        .WithMany("payment")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Mailo.Models.Wishlist", b =>
                {
                    b.HasOne("Mailo.Models.Product", "product")
                        .WithMany("wishlists")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Mailo.Models.User", "user")
                        .WithMany("wishlist")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Mailo.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");

                    b.Navigation("Payment")
                        .IsRequired();
                });

            modelBuilder.Entity("Mailo.Models.Product", b =>
                {
                    b.Navigation("OrderProducts");

                    b.Navigation("wishlists");
                });

            modelBuilder.Entity("Mailo.Models.User", b =>
                {
                    b.Navigation("Message");

                    b.Navigation("orders");

                    b.Navigation("payment");

                    b.Navigation("wishlist");
                });
#pragma warning restore 612, 618
        }
    }
}
