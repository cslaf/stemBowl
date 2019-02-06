﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using stembowl.Models;

namespace stembowl.Migrations.QuestionDb
{
    [DbContext(typeof(QuestionDbContext))]
    [Migration("20190203190540_TeamName")]
    partial class TeamName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("TeamID");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("TeamID");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("stembowl.Models.Answer", b =>
                {
                    b.Property<int>("AnswerID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Correct");

                    b.Property<int>("QuestionID");

                    b.Property<string>("Text");

                    b.HasKey("AnswerID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("stembowl.Models.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<int>("Format");

                    b.Property<string>("SubmitterID");

                    b.Property<string>("TeamID");

                    b.Property<string>("Text");

                    b.HasKey("QuestionID");

                    b.HasIndex("TeamID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("stembowl.Models.Team", b =>
                {
                    b.Property<string>("TeamID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LeaderId");

                    b.Property<string>("TeamName");

                    b.HasKey("TeamID");

                    b.HasIndex("LeaderId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("stembowl.Models.TeamAnswers", b =>
                {
                    b.Property<string>("TeamAnswersID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<bool>("Correct");

                    b.Property<string>("QuestionID");

                    b.Property<string>("TeamID");

                    b.HasKey("TeamAnswersID");

                    b.HasIndex("TeamID");

                    b.ToTable("TeamAnswers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUser", b =>
                {
                    b.HasOne("stembowl.Models.Team")
                        .WithMany("TeamMembers")
                        .HasForeignKey("TeamID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("stembowl.Models.Answer", b =>
                {
                    b.HasOne("stembowl.Models.Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("stembowl.Models.Question", b =>
                {
                    b.HasOne("stembowl.Models.Team")
                        .WithMany("Unanswered")
                        .HasForeignKey("TeamID");
                });

            modelBuilder.Entity("stembowl.Models.Team", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser", "Leader")
                        .WithMany()
                        .HasForeignKey("LeaderId");
                });

            modelBuilder.Entity("stembowl.Models.TeamAnswers", b =>
                {
                    b.HasOne("stembowl.Models.Team")
                        .WithMany("Answered")
                        .HasForeignKey("TeamID");
                });
#pragma warning restore 612, 618
        }
    }
}
