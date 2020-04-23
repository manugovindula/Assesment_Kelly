﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderProcess.API.Contexts;

namespace OrderProcess.API.Migrations
{
    [DbContext(typeof(ProcessOrderContext))]
    [Migration("20200418185321_Initial1")]
    partial class Initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderProcess.API.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new { Id = 1, ProductId = 1, Quantity = 10, UserId = 1 },
                        new { Id = 2, ProductId = 1, Quantity = 10, UserId = 1 },
                        new { Id = 3, ProductId = 2, Quantity = 10, UserId = 2 },
                        new { Id = 4, ProductId = 3, Quantity = 10, UserId = 2 },
                        new { Id = 5, ProductId = 2, Quantity = 10, UserId = 3 },
                        new { Id = 6, ProductId = 3, Quantity = 10, UserId = 3 }
                    );
                });

            modelBuilder.Entity("OrderProcess.API.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvaliableQuantity");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, AvaliableQuantity = 10, Price = 100 },
                        new { Id = 2, AvaliableQuantity = 3, Price = 1000 },
                        new { Id = 3, AvaliableQuantity = 0, Price = 10 }
                    );
                });

            modelBuilder.Entity("OrderProcess.API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Name = "Sam" },
                        new { Id = 2, Name = "Bob" },
                        new { Id = 3, Name = "Ben" }
                    );
                });

            modelBuilder.Entity("OrderProcess.API.Entities.Order", b =>
                {
                    b.HasOne("OrderProcess.API.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OrderProcess.API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
