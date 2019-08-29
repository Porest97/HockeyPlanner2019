﻿// <auto-generated />
using System;
using HockeyPlanner2019.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HockeyPlanner2019.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.Arena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArenaName");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("HomePage");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Arena");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("ClubName");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("ComanyName");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArenaId");

                    b.Property<int?>("AwayTeamScore");

                    b.Property<int?>("ClubId");

                    b.Property<int?>("ClubId1");

                    b.Property<int?>("GameCategoryId");

                    b.Property<DateTime>("GameDateTime");

                    b.Property<string>("GameNumber");

                    b.Property<int?>("GameStatusId");

                    b.Property<int?>("HomeTeamScore");

                    b.Property<int?>("PersonId");

                    b.Property<int?>("PersonId1");

                    b.Property<int?>("PersonId2");

                    b.Property<int?>("PersonId3");

                    b.Property<string>("TSMNumber");

                    b.HasKey("Id");

                    b.HasIndex("ArenaId");

                    b.HasIndex("ClubId");

                    b.HasIndex("ClubId1");

                    b.HasIndex("GameCategoryId");

                    b.HasIndex("GameStatusId");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.HasIndex("PersonId2");

                    b.HasIndex("PersonId3");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.GameCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GameCategoryName");

                    b.HasKey("Id");

                    b.ToTable("GameCategory");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.GameReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountPaidHD1");

                    b.Property<int>("AmountPaidHD2");

                    b.Property<int>("AmountPaidLD1");

                    b.Property<int>("AmountPaidLD2");

                    b.Property<int?>("GameId");

                    b.Property<int>("GameTotalKost");

                    b.Property<int>("HD1Alowens");

                    b.Property<int>("HD1Fee");

                    b.Property<int>("HD1LateGameKost");

                    b.Property<int>("HD1TotalFee");

                    b.Property<int>("HD1TravelKost");

                    b.Property<int>("HD2Alowens");

                    b.Property<int>("HD2Fee");

                    b.Property<int>("HD2LateGameKost");

                    b.Property<int>("HD2TotalFee");

                    b.Property<int>("HD2TravelKost");

                    b.Property<int>("LD1Alowens");

                    b.Property<int>("LD1Fee");

                    b.Property<int>("LD1LateGameKost");

                    b.Property<int>("LD1TotalFee");

                    b.Property<int>("LD1TravelKost");

                    b.Property<int>("LD2Alowens");

                    b.Property<int>("LD2Fee");

                    b.Property<int>("LD2LateGameKost");

                    b.Property<int>("LD2TotalFee");

                    b.Property<int>("LD2TravelKost");

                    b.Property<int?>("PersonId");

                    b.Property<int?>("PersonId1");

                    b.Property<int?>("PersonId2");

                    b.Property<int?>("PersonId3");

                    b.Property<int?>("ReceiptStatusId");

                    b.Property<int>("TotalAmountPaid");

                    b.Property<int>("TotalAmountToPay");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.HasIndex("PersonId2");

                    b.HasIndex("PersonId3");

                    b.HasIndex("ReceiptStatusId");

                    b.ToTable("GameReceipt");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.GameStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GameStatusName");

                    b.HasKey("Id");

                    b.ToTable("GameStatus");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankAccount");

                    b.Property<string>("BankName");

                    b.Property<string>("City");

                    b.Property<int?>("ClubId");

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("IdentityUserId");

                    b.Property<string>("LastName");

                    b.Property<int?>("PersonTypeId");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("Ssn");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("SwishNumber");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("IdentityUserId");

                    b.HasIndex("PersonTypeId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.PersonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonTypeName");

                    b.HasKey("Id");

                    b.ToTable("PersonType");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.ReceiptStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ReceiptStatusName");

                    b.HasKey("Id");

                    b.ToTable("ReceiptStatus");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceName");

                    b.HasKey("Id");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.ServiceReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId");

                    b.Property<int?>("PersonId");

                    b.Property<double>("Price");

                    b.Property<double>("Quantity");

                    b.Property<int?>("ReceiptStatusId");

                    b.Property<int?>("ServiceId");

                    b.Property<double>("TotalAmountPaid");

                    b.Property<double>("TotalAmountToPay");

                    b.Property<double>("TotalPayment");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PersonId");

                    b.HasIndex("ReceiptStatusId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceReceipt");
                });

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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.Game", b =>
                {
                    b.HasOne("HockeyPlanner2019.Models.DataModels.Arena", "Arena")
                        .WithMany()
                        .HasForeignKey("ArenaId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Club", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("ClubId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Club", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("ClubId1");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.GameCategory", "GameCategory")
                        .WithMany()
                        .HasForeignKey("GameCategoryId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.GameStatus", "GameStatus")
                        .WithMany()
                        .HasForeignKey("GameStatusId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Person", "HD1")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Person", "HD2")
                        .WithMany()
                        .HasForeignKey("PersonId1");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Person", "LD1")
                        .WithMany()
                        .HasForeignKey("PersonId2");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Person", "LD2")
                        .WithMany()
                        .HasForeignKey("PersonId3");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.GameReceipt", b =>
                {
                    b.HasOne("HockeyPlanner2019.Models.DataModels.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Person", "HD1")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Person", "HD2")
                        .WithMany()
                        .HasForeignKey("PersonId1");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Person", "LD1")
                        .WithMany()
                        .HasForeignKey("PersonId2");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Person", "LD2")
                        .WithMany()
                        .HasForeignKey("PersonId3");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.ReceiptStatus", "ReceiptStatus")
                        .WithMany()
                        .HasForeignKey("ReceiptStatusId");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.Person", b =>
                {
                    b.HasOne("HockeyPlanner2019.Models.DataModels.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.PersonType", "PersonType")
                        .WithMany()
                        .HasForeignKey("PersonTypeId");
                });

            modelBuilder.Entity("HockeyPlanner2019.Models.DataModels.ServiceReceipt", b =>
                {
                    b.HasOne("HockeyPlanner2019.Models.DataModels.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Person", "ServiceProvider")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.ReceiptStatus", "ReceiptStatus")
                        .WithMany()
                        .HasForeignKey("ReceiptStatusId");

                    b.HasOne("HockeyPlanner2019.Models.DataModels.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
