﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project.api.EntityModels;

namespace project.api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("project.api.EntityModels.Category", b =>
                {
                    b.Property<Guid>("ID_Category")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Category");

                    b.ToTable("Categaory");
                });

            modelBuilder.Entity("project.api.EntityModels.Posts", b =>
                {
                    b.Property<Guid>("ID_Post")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data_Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ID_Category")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Post_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("userID_User")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID_Post");

                    b.HasIndex("ID_Category");

                    b.HasIndex("userID_User");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("project.api.EntityModels.Reply", b =>
                {
                    b.Property<Guid>("ID_Reply")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryID_Category")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content_Reply")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_reply")
                        .HasColumnType("datetime2");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserID_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("postsID_Post")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID_Reply");

                    b.HasIndex("CategoryID_Category");

                    b.HasIndex("UserID_User");

                    b.HasIndex("postsID_Post");

                    b.ToTable("Reply");
                });

            modelBuilder.Entity("project.api.EntityModels.User", b =>
                {
                    b.Property<Guid>("ID_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Birth_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Confirmed_Email")
                        .HasColumnType("int");

                    b.Property<Guid>("Confirmed_Phone")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_User");

                    b.ToTable("User");
                });

            modelBuilder.Entity("project.api.EntityModels.catguser", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_Category")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_User")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ID_Category");

                    b.HasIndex("ID_User");

                    b.ToTable("catgusers");
                });

            modelBuilder.Entity("project.api.EntityModels.Posts", b =>
                {
                    b.HasOne("project.api.EntityModels.Category", "category")
                        .WithMany()
                        .HasForeignKey("ID_Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.api.EntityModels.User", "user")
                        .WithMany("Posts")
                        .HasForeignKey("userID_User");
                });

            modelBuilder.Entity("project.api.EntityModels.Reply", b =>
                {
                    b.HasOne("project.api.EntityModels.Category", null)
                        .WithMany("reply")
                        .HasForeignKey("CategoryID_Category");

                    b.HasOne("project.api.EntityModels.User", null)
                        .WithMany("reply")
                        .HasForeignKey("UserID_User");

                    b.HasOne("project.api.EntityModels.Posts", "posts")
                        .WithMany("reply")
                        .HasForeignKey("postsID_Post");
                });

            modelBuilder.Entity("project.api.EntityModels.catguser", b =>
                {
                    b.HasOne("project.api.EntityModels.Category", "category")
                        .WithMany("catgusers")
                        .HasForeignKey("ID_Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.api.EntityModels.User", "user")
                        .WithMany("catgusers")
                        .HasForeignKey("ID_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
