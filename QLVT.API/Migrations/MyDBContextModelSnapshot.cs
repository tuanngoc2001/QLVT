﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLVT.API.Data;

namespace QLVT.API.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QLVT.Data.Entities.BoPhan", b =>
                {
                    b.Property<Guid>("IDBP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("STT")
                        .HasColumnType("int");

                    b.Property<string>("TenBP")
                        .HasColumnType("ntext");

                    b.Property<string>("TenNDD")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IDBP");

                    b.ToTable("BoPhan");
                });

            modelBuilder.Entity("QLVT.Data.Entities.DangKy", b =>
                {
                    b.Property<Guid>("IDDK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDBP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenNguoiDK")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDDK");

                    b.HasIndex("IDBP");

                    b.ToTable("DangKy");
                });

            modelBuilder.Entity("QLVT.Data.Entities.MatHang", b =>
                {
                    b.Property<Guid>("IDMH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDDK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SL")
                        .HasColumnType("int");

                    b.Property<int>("STT")
                        .HasColumnType("int");

                    b.Property<string>("TenMH")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IDMH");

                    b.HasIndex("IDDK");

                    b.ToTable("MatHang");
                });

            modelBuilder.Entity("QLVT.Data.Entities.DangKy", b =>
                {
                    b.HasOne("QLVT.Data.Entities.BoPhan", "boPhan")
                        .WithMany("matHangs")
                        .HasForeignKey("IDBP");

                    b.Navigation("boPhan");
                });

            modelBuilder.Entity("QLVT.Data.Entities.MatHang", b =>
                {
                    b.HasOne("QLVT.Data.Entities.DangKy", "dangKy")
                        .WithMany("matHangs")
                        .HasForeignKey("IDDK");

                    b.Navigation("dangKy");
                });

            modelBuilder.Entity("QLVT.Data.Entities.BoPhan", b =>
                {
                    b.Navigation("matHangs");
                });

            modelBuilder.Entity("QLVT.Data.Entities.DangKy", b =>
                {
                    b.Navigation("matHangs");
                });
#pragma warning restore 612, 618
        }
    }
}