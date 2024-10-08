﻿// <auto-generated />
using Blazor_Login_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blazor_Login_System.Migrations
{
    [DbContext(typeof(MySqlDbContext))]
    [Migration("20240919134716_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Blazor_Login_System.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("emailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
