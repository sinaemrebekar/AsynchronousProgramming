﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250419090723_update_product_seed_data")]
    partial class update_product_seed_data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1417),
                            Name = "Meyve & Sebze",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1428),
                            Name = "Et & Tavuk",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1429),
                            Name = "Süt & Kahvaltılık",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1430),
                            Name = "Atıştırmalık",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(9,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1634),
                            Description = "Taze tarla domatesi",
                            ImagePath = "domates.jpg",
                            Name = "Domates",
                            Status = 1,
                            UnitPrice = 15.50m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1640),
                            Description = "Seradan taze salatalık",
                            ImagePath = "salatalik.jpg",
                            Name = "Salatalık",
                            Status = 1,
                            UnitPrice = 12.25m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1642),
                            Description = "Amasya elması",
                            ImagePath = "elma.jpg",
                            Name = "Elma",
                            Status = 1,
                            UnitPrice = 10.75m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1643),
                            Description = "Yerli patates",
                            ImagePath = "patates.jpg",
                            Name = "Patates",
                            Status = 1,
                            UnitPrice = 8.90m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1645),
                            Description = "Kuru soğan",
                            ImagePath = "sogan.jpg",
                            Name = "Soğan",
                            Status = 1,
                            UnitPrice = 7.30m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1646),
                            Description = "Yağsız dana kıyma",
                            ImagePath = "kiyma.jpg",
                            Name = "Dana Kıyma",
                            Status = 1,
                            UnitPrice = 210.00m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1647),
                            Description = "Taze tavuk fileto",
                            ImagePath = "tavuk.jpg",
                            Name = "Tavuk Göğsü",
                            Status = 1,
                            UnitPrice = 85.00m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1649),
                            Description = "Kayseri usulü fermente sucuk",
                            ImagePath = "sucuk.jpg",
                            Name = "Sucuk",
                            Status = 1,
                            UnitPrice = 120.00m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1650),
                            Description = "Kemikli kuzu pirzola",
                            ImagePath = "kuzupirzola.jpg",
                            Name = "Kuzu Pirzola",
                            Status = 1,
                            UnitPrice = 280.00m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1652),
                            Description = "Dilimli hindi füme",
                            ImagePath = "hindifume.jpg",
                            Name = "Hindi Füme",
                            Status = 1,
                            UnitPrice = 95.00m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1653),
                            Description = "Tam yağlı günlük süt",
                            ImagePath = "sut.jpg",
                            Name = "Süt",
                            Status = 1,
                            UnitPrice = 18.50m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1655),
                            Description = "Ezine tipi beyaz peynir",
                            ImagePath = "peynir.jpg",
                            Name = "Beyaz Peynir",
                            Status = 1,
                            UnitPrice = 98.00m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1656),
                            Description = "Kahvaltılık doğal tereyağı",
                            ImagePath = "tereyag.jpg",
                            Name = "Tereyağı",
                            Status = 1,
                            UnitPrice = 140.00m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1657),
                            Description = "Siyah sele zeytin",
                            ImagePath = "zeytin.jpg",
                            Name = "Zeytin",
                            Status = 1,
                            UnitPrice = 75.00m
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1659),
                            Description = "Süzme çiçek balı",
                            ImagePath = "bal.jpg",
                            Name = "Bal",
                            Status = 1,
                            UnitPrice = 160.00m
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1660),
                            Description = "Patates cipsi 150g",
                            ImagePath = "cips.jpg",
                            Name = "Cips",
                            Status = 1,
                            UnitPrice = 23.00m
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1662),
                            Description = "Bitter çikolata 80g",
                            ImagePath = "cikolata.jpg",
                            Name = "Çikolata",
                            Status = 1,
                            UnitPrice = 18.00m
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1663),
                            Description = "Kakaolu gofret",
                            ImagePath = "gofret.jpg",
                            Name = "Gofret",
                            Status = 1,
                            UnitPrice = 9.00m
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1665),
                            Description = "Limon aromalı gazoz",
                            ImagePath = "gazoz.jpg",
                            Name = "Gazoz",
                            Status = 1,
                            UnitPrice = 7.50m
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1666),
                            Description = "Kremalı bisküvi",
                            ImagePath = "biskuvi.jpg",
                            Name = "Bisküvi",
                            Status = 1,
                            UnitPrice = 11.75m
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.Product", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
