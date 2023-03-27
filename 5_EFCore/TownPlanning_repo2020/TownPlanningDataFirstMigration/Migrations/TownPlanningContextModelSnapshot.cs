﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TownplanningEfApp.Migration.Data;

namespace TownPlanningEFLibraryDataFirstMigration.Migrations
{
    [DbContext(typeof(TownPlanningContext))]
    partial class TownPlanningContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TownplanningEfApp.Migration.Domain.AadhaarCard", b =>
                {
                    b.Property<int>("AadhaarNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidTill")
                        .HasColumnType("datetime2");

                    b.HasKey("AadhaarNo");

                    b.ToTable("AadhaarCards");
                });

            modelBuilder.Entity("TownplanningEfApp.Migration.Domain.Asset", b =>
                {
                    b.Property<int>("AssetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlotNo")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VillageId")
                        .HasColumnType("int");

                    b.HasKey("AssetId");

                    b.HasIndex("VillageId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("TownplanningEfApp.Migration.Domain.AssetDetails", b =>
                {
                    b.Property<int>("AssetID")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<float>("OwnershipShare")
                        .HasColumnType("real");

                    b.HasKey("AssetID", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("AssetDetails");
                });

            modelBuilder.Entity("TownplanningEfApp.Migration.Domain.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AadhaarNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("VillageId")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.HasIndex("AadhaarNo");

                    b.HasIndex("RoleId");

                    b.HasIndex("VillageId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("TownplanningEfApp.Migration.Domain.Village", b =>
                {
                    b.Property<int>("VillageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pincode")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VillageId");

                    b.ToTable("Villages");
                });

            modelBuilder.Entity("TownplanningEfApp.Migration.Domain.VillageAdministrationRole", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfJoin")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("RoleTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.HasIndex("PersonId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("TownplanningEfApp.Migration.Domain.Asset", b =>
                {
                    b.HasOne("TownplanningEfApp.Migration.Domain.Village", "Village")
                        .WithMany()
                        .HasForeignKey("VillageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TownplanningEfApp.Migration.Domain.AssetDetails", b =>
                {
                    b.HasOne("TownplanningEfApp.Migration.Domain.Asset", "Property")
                        .WithMany("Owners")
                        .HasForeignKey("AssetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TownplanningEfApp.Migration.Domain.Person", "Owner")
                        .WithMany("Assets")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("TownplanningEfApp.Migration.Domain.Person", b =>
                {
                    b.HasOne("TownplanningEfApp.Migration.Domain.AadhaarCard", "Aadhaar")
                        .WithMany()
                        .HasForeignKey("AadhaarNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TownplanningEfApp.Migration.Domain.VillageAdministrationRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("TownplanningEfApp.Migration.Domain.Village", "HomeTown")
                        .WithMany("Residents")
                        .HasForeignKey("VillageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TownplanningEfApp.Migration.Domain.VillageAdministrationRole", b =>
                {
                    b.HasOne("TownplanningEfApp.Migration.Domain.Person", "InChargePerson")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });
#pragma warning restore 612, 618
        }
    }
}