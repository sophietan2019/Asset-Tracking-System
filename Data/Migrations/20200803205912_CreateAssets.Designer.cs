﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(AssetContext))]
    [Migration("20200803205912_CreateAssets")]
    partial class CreateAssets
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssetTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TagNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.ToTable("Asset");

                    b.HasData(
                        new
                        {
                            Id = 10001,
                            AssetTypeId = 1,
                            Description = "17.3 Laptop",
                            Manufacturer = "Dell",
                            Model = "Inspiration 5520",
                            SerialNumber = " i3793-5841BLK-PUS",
                            TagNumber = "C101"
                        },
                        new
                        {
                            Id = 10002,
                            AssetTypeId = 2,
                            Description = "Colour lcd monitor",
                            Manufacturer = "Acer",
                            Model = "S191HQL",
                            SerialNumber = "9999333iiie33",
                            TagNumber = "M101"
                        },
                        new
                        {
                            Id = 10003,
                            AssetTypeId = 3,
                            Description = "Telephone",
                            Manufacturer = "Cisco",
                            SerialNumber = "123456fffe3p3",
                            TagNumber = "P101"
                        },
                        new
                        {
                            Id = 10004,
                            AssetTypeId = 1,
                            Description = "14 Notebook",
                            Manufacturer = "Dell",
                            Model = "Latitude 3400",
                            SerialNumber = "i3793-5e378-BLK-AOC",
                            TagNumber = "C102"
                        },
                        new
                        {
                            Id = 10005,
                            AssetTypeId = 3,
                            Description = "Business IP Phone",
                            Manufacturer = "Polycom",
                            Model = "VVX 150",
                            SerialNumber = "iiik-999-0olk",
                            TagNumber = "P102"
                        },
                        new
                        {
                            Id = 10006,
                            AssetTypeId = 1,
                            Description = "All-in-One PC",
                            Manufacturer = " HP",
                            Model = "Pavilion 27",
                            SerialNumber = "88POL-999345-00KMM",
                            TagNumber = "C102"
                        },
                        new
                        {
                            Id = 10007,
                            AssetTypeId = 3,
                            Description = "Office Phone",
                            Manufacturer = "Avaya",
                            Model = "T7316E",
                            SerialNumber = "NT8B27",
                            TagNumber = "P103"
                        });
                });

            modelBuilder.Entity("Domain.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AssetType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Monitor"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Phone"
                        });
                });

            modelBuilder.Entity("Domain.Asset", b =>
                {
                    b.HasOne("Domain.AssetType", "AssetType")
                        .WithMany("Assets")
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
