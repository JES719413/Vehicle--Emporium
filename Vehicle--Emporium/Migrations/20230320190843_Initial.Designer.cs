﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vehicle__Emporium.Data;

#nullable disable

namespace Vehicle__Emporium.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230320190843_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Vehicle__Emporium.Models.Engine", b =>
                {
                    b.Property<int>("engineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("engineID"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("engineHour")
                        .HasColumnType("int");

                    b.Property<string>("engineMake")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<string>("engineModel")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<int>("enginePower")
                        .HasColumnType("int");

                    b.Property<string>("engineType")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<int>("vehicleID")
                        .HasColumnType("int");

                    b.HasKey("engineID");

                    b.ToTable("Engines");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Engine");
                });

            modelBuilder.Entity("Vehicle__Emporium.Models.Vehicles", b =>
                {
                    b.Property<int>("vehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("vehicleID"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUpload")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("miles")
                        .HasColumnType("int");

                    b.Property<int>("mpg")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("vehicleMake")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicleModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("vehicleID");

                    b.ToTable("Vehicles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Vehicles");
                });

            modelBuilder.Entity("Vehicle__Emporium.Models.BoatEngine", b =>
                {
                    b.HasBaseType("Vehicle__Emporium.Models.Engine");

                    b.Property<string>("engineDriveType")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<string>("propellerMaterial")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<string>("propellerType")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.HasDiscriminator().HasValue("BoatEngine");
                });

            modelBuilder.Entity("Vehicle__Emporium.Models.Boats", b =>
                {
                    b.HasBaseType("Vehicle__Emporium.Models.Vehicles");

                    b.Property<int>("boatCapcity")
                        .HasColumnType("int");

                    b.Property<string>("boatClass")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<string>("boatFuel")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<int>("boatFuelTanks")
                        .HasColumnType("int");

                    b.Property<int>("boatLength")
                        .HasColumnType("int");

                    b.Property<string>("boatMaterial")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<string>("boatShape")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<string>("boatType")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.HasDiscriminator().HasValue("Boats");
                });

            modelBuilder.Entity("Vehicle__Emporium.Models.Cars", b =>
                {
                    b.HasBaseType("Vehicle__Emporium.Models.Vehicles");

                    b.Property<string>("carType")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<int>("fuelCapcity")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cars");
                });

            modelBuilder.Entity("Vehicle__Emporium.Models.Motorcycles", b =>
                {
                    b.HasBaseType("Vehicle__Emporium.Models.Vehicles");

                    b.Property<string>("bikeEngineType")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<string>("bikeType")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<int>("chainLength")
                        .HasColumnType("int");

                    b.Property<string>("chainType")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<int>("rideHeight")
                        .HasColumnType("int");

                    b.Property<int>("sideCar")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Motorcycles");
                });

            modelBuilder.Entity("Vehicle__Emporium.Models.MotorHomes", b =>
                {
                    b.HasBaseType("Vehicle__Emporium.Models.Vehicles");

                    b.Property<string>("fuelType")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<decimal>("length")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("MotorHomes_length");

                    b.Property<string>("rvClass")
                        .IsRequired()
                        .HasColumnType("varchar(75)")
                        .HasColumnName("MotorHomes_rvClass");

                    b.Property<int>("sleeps")
                        .HasColumnType("int");

                    b.Property<int>("slideOuts")
                        .HasColumnType("int")
                        .HasColumnName("MotorHomes_slideOuts");

                    b.HasDiscriminator().HasValue("MotorHomes");
                });

            modelBuilder.Entity("Vehicle__Emporium.Models.TravelTrailer", b =>
                {
                    b.HasBaseType("Vehicle__Emporium.Models.Vehicles");

                    b.Property<decimal>("dryWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("rvClass")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<int>("slideOuts")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("TravelTrailer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
