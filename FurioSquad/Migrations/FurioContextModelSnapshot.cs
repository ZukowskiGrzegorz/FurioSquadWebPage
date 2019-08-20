﻿// <auto-generated />
using System;
using FurioSquad.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FurioSquad.Migrations
{
    [DbContext(typeof(FurioContext))]
    partial class FurioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FurioSquad.Models.BlogViewModel", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("Modified");

                    b.Property<int>("PostDislikes");

                    b.Property<int?>("PostId");

                    b.Property<int>("PostLikes");

                    b.Property<DateTime>("PostedOn");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Title");

                    b.Property<int>("TotalPosts");

                    b.HasKey("ID");

                    b.HasIndex("PostId");

                    b.ToTable("BlogViewModel");
                });

            modelBuilder.Entity("FurioSquad.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("LikeCount");

                    b.Property<DateTime>("PostDate");

                    b.Property<int>("PostId");

                    b.HasKey("CommentId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("FurioSquad.Models.CommentLike", b =>
                {
                    b.Property<int>("CommentLikeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentId");

                    b.Property<int>("Dislike");

                    b.Property<int>("Like");

                    b.HasKey("CommentLikeId");

                    b.HasIndex("CommentId");

                    b.ToTable("CommentLikes");
                });

            modelBuilder.Entity("FurioSquad.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(10000);

                    b.Property<DateTime>("EditedDate");

                    b.Property<int>("LikeCount");

                    b.Property<DateTime>("PostDate");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(300);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("UserId");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("FurioSquad.Models.PostLike", b =>
                {
                    b.Property<int>("PostLikeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Dislike");

                    b.Property<int>("Like");

                    b.Property<int>("PostId");

                    b.HasKey("PostLikeId");

                    b.HasIndex("PostId");

                    b.ToTable("PostLikes");
                });

            modelBuilder.Entity("FurioSquad.Models.PostTag", b =>
                {
                    b.Property<int>("PostTagId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PostId");

                    b.Property<int>("TagId");

                    b.HasKey("PostTagId");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");
                });

            modelBuilder.Entity("FurioSquad.Models.Replie", b =>
                {
                    b.Property<int>("ReplieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int>("CommentId");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("LikeCount");

                    b.Property<DateTime>("PostDate");

                    b.Property<int?>("PostId");

                    b.HasKey("ReplieId");

                    b.HasIndex("PostId");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("FurioSquad.Models.ReplieLike", b =>
                {
                    b.Property<int>("ReplieLikeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Dislike");

                    b.Property<int>("Like");

                    b.Property<int>("ReplieId");

                    b.HasKey("ReplieLikeId");

                    b.HasIndex("ReplieId");

                    b.ToTable("ReplieLikes");
                });

            modelBuilder.Entity("FurioSquad.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogViewModelID");

                    b.Property<string>("BlogViewModelID1");

                    b.Property<int>("Count");

                    b.Property<string>("Name");

                    b.HasKey("TagId");

                    b.HasIndex("BlogViewModelID");

                    b.HasIndex("BlogViewModelID1");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("FurioSquad.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nick")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTime>("RegistredDate");

                    b.Property<string>("Role")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FurioSquad.Models.BlogViewModel", b =>
                {
                    b.HasOne("FurioSquad.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FurioSquad.Models.Comment", b =>
                {
                    b.HasOne("FurioSquad.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FurioSquad.Models.CommentLike", b =>
                {
                    b.HasOne("FurioSquad.Models.Comment", "Comment")
                        .WithMany("CommentLikes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FurioSquad.Models.Post", b =>
                {
                    b.HasOne("FurioSquad.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FurioSquad.Models.PostLike", b =>
                {
                    b.HasOne("FurioSquad.Models.Post", "Post")
                        .WithMany("PostLikes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FurioSquad.Models.PostTag", b =>
                {
                    b.HasOne("FurioSquad.Models.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FurioSquad.Models.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FurioSquad.Models.Replie", b =>
                {
                    b.HasOne("FurioSquad.Models.Post", "Post")
                        .WithMany("Replies")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FurioSquad.Models.ReplieLike", b =>
                {
                    b.HasOne("FurioSquad.Models.Replie", "Replie")
                        .WithMany("ReplieLikes")
                        .HasForeignKey("ReplieId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FurioSquad.Models.Tag", b =>
                {
                    b.HasOne("FurioSquad.Models.BlogViewModel")
                        .WithMany("PostTags")
                        .HasForeignKey("BlogViewModelID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FurioSquad.Models.BlogViewModel")
                        .WithMany("Tag")
                        .HasForeignKey("BlogViewModelID1")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
