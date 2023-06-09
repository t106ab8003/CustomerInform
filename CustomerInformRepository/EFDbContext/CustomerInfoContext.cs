﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CustomerInformRepository.EFDbContext
{
    public partial class CustomerInfoContext : DbContext
    {
        public CustomerInfoContext()
        {
        }

        public CustomerInfoContext(DbContextOptions<CustomerInfoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.custid)
                    .HasName("PK_customers");

                entity.Property(e => e.custid).ValueGeneratedNever();

                entity.Property(e => e.contactnum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.custnm).HasMaxLength(50);

                entity.Property(e => e.perosnalid)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}