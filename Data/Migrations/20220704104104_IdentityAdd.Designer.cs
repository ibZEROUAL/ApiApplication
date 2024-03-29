﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220704104104_IdentityAdd")]
    partial class IdentityAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActivityImmigrant", b =>
                {
                    b.Property<int>("ActivitiesId")
                        .HasColumnType("int");

                    b.Property<int>("ImmigrantsId")
                        .HasColumnType("int");

                    b.HasKey("ActivitiesId", "ImmigrantsId");

                    b.HasIndex("ImmigrantsId");

                    b.ToTable("ActivityImmigrant");
                });

            modelBuilder.Entity("API.entities.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ActivityDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActivityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActivityPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActivityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChefEquipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChefEquipeId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("API.entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("API.entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId1")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("PersonId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("API.entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LocationCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("API.entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("API.entities.Rapport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdministratorId")
                        .HasColumnType("int");

                    b.Property<string>("DateRapport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Rapports");
                });

            modelBuilder.Entity("API.entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameService")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ImmigrantService", b =>
                {
                    b.Property<int>("ImmigrantsId")
                        .HasColumnType("int");

                    b.Property<int>("ServicesId")
                        .HasColumnType("int");

                    b.HasKey("ImmigrantsId", "ServicesId");

                    b.HasIndex("ServicesId");

                    b.ToTable("ImmigrantService");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("API.entities.Administrator", b =>
                {
                    b.HasBaseType("API.entities.Person");

                    b.ToTable("Administrators", (string)null);
                });

            modelBuilder.Entity("API.entities.Employer", b =>
                {
                    b.HasBaseType("API.entities.Person");

                    b.Property<string>("EmployerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("TypeEquipe")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("ServiceId");

                    b.ToTable("Employer", (string)null);
                });

            modelBuilder.Entity("API.entities.Immigrant", b =>
                {
                    b.HasBaseType("API.entities.Person");

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vulnerability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("locationId")
                        .HasColumnType("int");

                    b.HasIndex("locationId");

                    b.ToTable("Immigrants", (string)null);
                });

            modelBuilder.Entity("API.entities.Assistant", b =>
                {
                    b.HasBaseType("API.entities.Employer");

                    b.Property<int?>("ChefEquipeId")
                        .HasColumnType("int");

                    b.HasIndex("ChefEquipeId");

                    b.ToTable("Assistants", (string)null);
                });

            modelBuilder.Entity("API.entities.ChefEquipe", b =>
                {
                    b.HasBaseType("API.entities.Employer");

                    b.ToTable("ChefEquipes", (string)null);
                });

            modelBuilder.Entity("ActivityImmigrant", b =>
                {
                    b.HasOne("API.entities.Activity", null)
                        .WithMany()
                        .HasForeignKey("ActivitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.entities.Immigrant", null)
                        .WithMany()
                        .HasForeignKey("ImmigrantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.entities.Activity", b =>
                {
                    b.HasOne("API.entities.ChefEquipe", "ChefEquipe")
                        .WithMany("Activities")
                        .HasForeignKey("ChefEquipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChefEquipe");
                });

            modelBuilder.Entity("API.entities.AppUserRole", b =>
                {
                    b.HasOne("API.entities.Person", "Person")
                        .WithMany("UserRoles")
                        .HasForeignKey("PersonId");

                    b.HasOne("API.entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.entities.AppRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId1");

                    b.HasOne("API.entities.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("API.entities.Rapport", b =>
                {
                    b.HasOne("API.entities.Administrator", "Administrator")
                        .WithMany("rapports")
                        .HasForeignKey("AdministratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.entities.Service", "Service")
                        .WithMany("rapports")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrator");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("ImmigrantService", b =>
                {
                    b.HasOne("API.entities.Immigrant", null)
                        .WithMany()
                        .HasForeignKey("ImmigrantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.entities.Service", null)
                        .WithMany()
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("API.entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("API.entities.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("API.entities.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("API.entities.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.entities.Administrator", b =>
                {
                    b.HasOne("API.entities.Person", null)
                        .WithOne()
                        .HasForeignKey("API.entities.Administrator", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.entities.Employer", b =>
                {
                    b.HasOne("API.entities.Person", null)
                        .WithOne()
                        .HasForeignKey("API.entities.Employer", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("API.entities.Service", null)
                        .WithMany("Employers")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("API.entities.Immigrant", b =>
                {
                    b.HasOne("API.entities.Person", null)
                        .WithOne()
                        .HasForeignKey("API.entities.Immigrant", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("API.entities.Location", "Location")
                        .WithMany("Immigrants")
                        .HasForeignKey("locationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("API.entities.Assistant", b =>
                {
                    b.HasOne("API.entities.ChefEquipe", "ChefEquipe")
                        .WithMany("Assistants")
                        .HasForeignKey("ChefEquipeId");

                    b.HasOne("API.entities.Employer", null)
                        .WithOne()
                        .HasForeignKey("API.entities.Assistant", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("ChefEquipe");
                });

            modelBuilder.Entity("API.entities.ChefEquipe", b =>
                {
                    b.HasOne("API.entities.Employer", null)
                        .WithOne()
                        .HasForeignKey("API.entities.ChefEquipe", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.entities.AppRole", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("API.entities.Location", b =>
                {
                    b.Navigation("Immigrants");
                });

            modelBuilder.Entity("API.entities.Person", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("API.entities.Service", b =>
                {
                    b.Navigation("Employers");

                    b.Navigation("rapports");
                });

            modelBuilder.Entity("API.entities.Administrator", b =>
                {
                    b.Navigation("rapports");
                });

            modelBuilder.Entity("API.entities.ChefEquipe", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Assistants");
                });
#pragma warning restore 612, 618
        }
    }
}
