﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BO_DotNet_6.Models.Entities;

namespace BO_DotNet_6.Context
{
    public partial class TestingContext : DbContext
    {
        public TestingContext()
        {
        }

        public TestingContext(DbContextOptions<TestingContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Initial Catalog=Testing;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            }
        }
        public virtual DbSet<ClientType> ClientType { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<Deparment> Deparment { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Restriction> Restriction { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserPermission> UserPermission { get; set; }
        public virtual DbSet<UserRestriction> UserRestriction { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientType>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Boss)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(2083)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Deparment>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClientType)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.ClientTypeId)
                    .HasConstraintName("FK_People_ClientType");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_People_Company");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("FK_People_ContactType");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_People_Deparment");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Restriction>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleId).HasMaxLength(450);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.People)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.PeopleId)
                    .HasConstraintName("FK_User_People");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPermission_Permission");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPermission_User");
            });

            modelBuilder.Entity<UserRestriction>(entity =>
            {
                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Restriction)
                    .WithMany(p => p.UserRestriction)
                    .HasForeignKey(d => d.RestrictionId)
                    .HasConstraintName("FK_UserRestriction_Restriction");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRestriction)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRestriction_User");
            });

            OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}