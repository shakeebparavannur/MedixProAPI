﻿// <auto-generated />
using System;
using MedixProDAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedixProDAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MedixProDAL.Entities.CustomerProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedOn");

                    b.Property<DateTime?>("DateofBirth")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint")
                        .HasColumnName("DeletedBy");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("DeletedOn");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("EmergencyContact")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("ModifiedOn");

                    b.HasKey("Id");

                    b.ToTable("CustomerProfiles");
                });

            modelBuilder.Entity("MedixProDAL.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedOn");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint")
                        .HasColumnName("DeletedBy");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("DeletedOn");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("ModifiedOn");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
