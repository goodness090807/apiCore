﻿// <auto-generated />
using APICore.Datas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace APICore.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20201016131722_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("APICore.Models.UserInfo", b =>
                {
                    b.Property<string>("userId")
                        .HasColumnType("text");

                    b.Property<string>("mail")
                        .HasColumnType("text");

                    b.Property<bool>("sex")
                        .HasColumnType("boolean");

                    b.Property<string>("userName")
                        .HasColumnType("text");

                    b.Property<string>("userPassword")
                        .HasColumnType("text");

                    b.HasKey("userId");

                    b.ToTable("UserInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
