﻿// <auto-generated />
using EAD_CA_PROJECT_INVEST.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EAD_CA_PROJECT_INVEST.Migrations
{
    [DbContext(typeof(INVESTContext))]
    [Migration("20220418195736_Test5")]
    partial class Test5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EAD_CA_PROJECT_INVEST.Model.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<float>("PurchasePrice")
                        .HasColumnType("real");

                    b.Property<int>("StockID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("StockID");

                    b.HasIndex("UserID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("EAD_CA_PROJECT_INVEST.Model.Stock", b =>
                {
                    b.Property<int>("StockID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockID"), 1L, 1);

                    b.Property<string>("ExchangeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("SellPrice")
                        .HasColumnType("real");

                    b.Property<string>("StockName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("StockPrice")
                        .HasColumnType("real");

                    b.Property<string>("StockTicker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalShares")
                        .HasColumnType("real");

                    b.HasKey("StockID");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("EAD_CA_PROJECT_INVEST.Model.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("EAD_CA_PROJECT_INVEST.Model.Order", b =>
                {
                    b.HasOne("EAD_CA_PROJECT_INVEST.Model.Stock", "Stock")
                        .WithMany("Order")
                        .HasForeignKey("StockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EAD_CA_PROJECT_INVEST.Model.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EAD_CA_PROJECT_INVEST.Model.Stock", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("EAD_CA_PROJECT_INVEST.Model.User", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
