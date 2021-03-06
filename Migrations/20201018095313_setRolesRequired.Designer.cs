﻿// <auto-generated />
using System;
using APICore.Datas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace APICore.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20201018095313_setRolesRequired")]
    partial class setRolesRequired
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("APICore.Models.TodoList", b =>
                {
                    b.Property<string>("listId")
                        .HasColumnType("text");

                    b.Property<string>("content")
                        .HasColumnType("text");

                    b.Property<DateTime>("createDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("listType")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.HasKey("listId");

                    b.ToTable("TodoLists");
                });

            modelBuilder.Entity("APICore.Models.UserInfo", b =>
                {
                    b.Property<string>("userId")
                        .HasColumnType("text");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("sex")
                        .HasColumnType("boolean");

                    b.Property<string>("userAccount")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("userPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("userRoles")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("userId");

                    b.ToTable("UserInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
