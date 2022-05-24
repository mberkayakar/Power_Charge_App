﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PowerSarj_2022.DataAccess.Concrete.Context.EfContext;

namespace PowerSarj_2022.DataAccess.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AdminId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AdminName");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.AllowedSites", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DeviceId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("AllowedSites");
                });

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("charginguser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("devicename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobilecharging")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("site")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("DeviceId");

                    b.HasIndex("UserId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.Fill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("admin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("lastbalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.Property<string>("userid1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id")
                        .HasName("FillId");

                    b.HasIndex("userid1");

                    b.ToTable("Fills");
                });

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.Operation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<int?>("_id")
                        .HasColumnType("int");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("deviceid")
                        .HasColumnType("int");

                    b.Property<int>("duration")
                        .HasColumnType("int");

                    b.Property<double>("energy")
                        .HasColumnType("float");

                    b.Property<string>("operation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userid")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id")
                        .HasName("OperationId");

                    b.HasIndex("deviceid");

                    b.HasIndex("userid");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.User", b =>
                {
                    b.Property<string>("userid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("__v")
                        .HasColumnType("int");

                    b.Property<int>("_id")
                        .HasColumnType("int");

                    b.Property<decimal>("balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("cardid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chargingdevice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("site")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userid")
                        .HasName("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.AllowedSites", b =>
                {
                    b.HasOne("PowerSarj_2022.Entities.Concrete.Device", null)
                        .WithMany("allowedSites")
                        .HasForeignKey("DeviceId");
                });

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.Device", b =>
                {
                    b.HasOne("PowerSarj_2022.Entities.Concrete.User", "User")
                        .WithMany("devices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.Fill", b =>
                {
                    b.HasOne("PowerSarj_2022.Entities.Concrete.User", "user")
                        .WithMany("fills")
                        .HasForeignKey("userid1");

                    b.Navigation("user");
                });

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.Operation", b =>
                {
                    b.HasOne("PowerSarj_2022.Entities.Concrete.Device", "device")
                        .WithMany("operations")
                        .HasForeignKey("deviceid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PowerSarj_2022.Entities.Concrete.User", "user")
                        .WithMany("operations")
                        .HasForeignKey("userid");

                    b.Navigation("device");

                    b.Navigation("user");
                });

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.Device", b =>
                {
                    b.Navigation("allowedSites");

                    b.Navigation("operations");
                });

            modelBuilder.Entity("PowerSarj_2022.Entities.Concrete.User", b =>
                {
                    b.Navigation("devices");

                    b.Navigation("fills");

                    b.Navigation("operations");
                });
#pragma warning restore 612, 618
        }
    }
}
