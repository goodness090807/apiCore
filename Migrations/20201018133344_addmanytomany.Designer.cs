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
    [Migration("20201018133344_addmanytomany")]
    partial class addmanytomany
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

                    b.Property<string>("UserInfouserId")
                        .HasColumnType("text");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("character varying(1000)")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("createDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("listType")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("listId");

                    b.HasIndex("UserInfouserId");

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

            modelBuilder.Entity("APICore.Models.UsersLists", b =>
                {
                    b.Property<string>("userId")
                        .HasColumnType("text");

                    b.Property<string>("listId")
                        .HasColumnType("text");

                    b.Property<string>("TodoListlistId")
                        .HasColumnType("text");

                    b.Property<string>("UserInfouserId")
                        .HasColumnType("text");

                    b.HasKey("userId", "listId");

                    b.HasIndex("TodoListlistId");

                    b.HasIndex("UserInfouserId");

                    b.ToTable("UsersLists");
                });

            modelBuilder.Entity("APICore.Models.TodoList", b =>
                {
                    b.HasOne("APICore.Models.UserInfo", null)
                        .WithMany("TodoLists")
                        .HasForeignKey("UserInfouserId");
                });

            modelBuilder.Entity("APICore.Models.UsersLists", b =>
                {
                    b.HasOne("APICore.Models.TodoList", "TodoList")
                        .WithMany()
                        .HasForeignKey("TodoListlistId");

                    b.HasOne("APICore.Models.UserInfo", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserInfouserId");
                });
#pragma warning restore 612, 618
        }
    }
}
