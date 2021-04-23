﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayerProject.Data;

namespace NLayerProject.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210421211855_AddPerson")]
    partial class AddPerson
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NLayerProject.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Kalem"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Defter"
                        });
                });

            modelBuilder.Entity("NLayerProject.Core.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("NLayerProject.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("InnerBarcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal (18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Kurşun Kalem",
                            Price = 50.5m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Tükenmez Kalem",
                            Price = 75.5m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Pilot Kalem",
                            Price = 100.5m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Küçük Boy Defter",
                            Price = 50.5m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Orta Boy Defter",
                            Price = 60.5m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Büyük Boy Defter",
                            Price = 70.5m,
                            Stock = 100
                        });
                });

            modelBuilder.Entity("NLayerProject.Core.Models.Product", b =>
                {
                    b.HasOne("NLayerProject.Core.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NLayerProject.Core.Models.Category", b =>
                {
                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
