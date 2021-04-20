﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OA_Repository;

namespace OA_Repository.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210420171809_MyInitialMigration")]
    partial class MyInitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OA_DataAccess.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("OA_DataAccess.ProductDetails", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockAvailable")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("OA_DataAccess.ProductDetails", b =>
                {
                    b.HasOne("OA_DataAccess.Product", "Product")
                        .WithOne("ProductDetails")
                        .HasForeignKey("OA_DataAccess.ProductDetails", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OA_DataAccess.Product", b =>
                {
                    b.Navigation("ProductDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
