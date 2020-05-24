﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wp.Data;

namespace Wp.Web.Api.Migrations
{
    [DbContext(typeof(WpDbContext))]
    partial class WpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

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

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Name");

                    b.Property<int>("ResumeId");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.EducationItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<int>("EducationId");

                    b.Property<string>("Name");

                    b.Property<string>("Period");

                    b.Property<string>("Place");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.ToTable("EducationItem");
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("Function");

                    b.Property<string>("Name");

                    b.Property<string>("Period");

                    b.Property<int>("ResumeId");

                    b.Property<string>("Tasks");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<int>("ExperienceId");

                    b.Property<string>("Name");

                    b.Property<string>("Technology");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.Resume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("ApplicationUserName");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("LinkedIn");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Summary");

                    b.Property<string>("Town");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Resume");
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("Name");

                    b.Property<int>("ResumeId");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.SkillItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("Level");

                    b.Property<string>("LevelDescription");

                    b.Property<string>("Name");

                    b.Property<int>("SkillId");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillItem");
                });

            modelBuilder.Entity("Wp.Core.Domain.Configuration.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.ToTable("Setting");
                });

            modelBuilder.Entity("Wp.Core.Domain.Localization.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("FlagImageFileName")
                        .HasMaxLength(50);

                    b.Property<string>("LanguageCulture")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("Published");

                    b.Property<bool>("Rtl");

                    b.Property<string>("UniqueSeoCode")
                        .HasMaxLength(2);

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("Wp.Core.Domain.Localization.LocaleStringResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LanguageId");

                    b.Property<string>("ResourceName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ResourceValue")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("LocaleStringResource");
                });

            modelBuilder.Entity("Wp.Core.Domain.Localization.LocalizedProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntityId");

                    b.Property<int>("LanguageId");

                    b.Property<string>("LocaleKey")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("LocaleKeyGroup")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("LocaleValue")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("LocalizedProperty");
                });

            modelBuilder.Entity("Wp.Core.Domain.Logging.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("FullMessage");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(200);

                    b.Property<string>("Level");

                    b.Property<string>("PageUrl");

                    b.Property<string>("ReferrerUrl");

                    b.Property<string>("ShortMessage")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("Wp.Core.Domain.Media.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("MimeType");

                    b.Property<string>("Name");

                    b.Property<byte[]>("PhotoBinary");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("Wp.Core.Domain.Sections.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<int>("WebPageId");

                    b.HasKey("Id");

                    b.HasIndex("WebPageId");

                    b.ToTable("Section");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Section");
                });

            modelBuilder.Entity("Wp.Core.Domain.Seo.UrlRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("EntityId");

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<bool>("IsActive");

                    b.Property<int>("LanguageId");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("UrlRecord");
                });

            modelBuilder.Entity("Wp.Core.Domain.WebPages.WebPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllowAnonymousAccess");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("NavigationName")
                        .IsRequired();

                    b.Property<int>("ParentId");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<string>("VirtualPath")
                        .IsRequired();

                    b.Property<bool>("Visible");

                    b.HasKey("Id");

                    b.ToTable("WebPage");
                });

            modelBuilder.Entity("Wp.Core.Domain.WebPages.WebPageRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Name");

                    b.Property<int>("PermissionLevelId");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<int>("WebPageId");

                    b.HasKey("Id");

                    b.HasIndex("WebPageId");

                    b.ToTable("WebPage_Role_Mapping");
                });

            modelBuilder.Entity("Wp.Core.Security.ApplicationUser", b =>
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

                    b.Property<int?>("ResumeId");

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

                    b.HasIndex("ResumeId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Wp.Core.Domain.Sections.ContactFormSection", b =>
                {
                    b.HasBaseType("Wp.Core.Domain.Sections.Section");

                    b.Property<string>("EmailBcc");

                    b.Property<string>("EmailCc");

                    b.Property<string>("EmailTo")
                        .IsRequired();

                    b.Property<bool>("ExtendedEnabled");

                    b.Property<string>("IntroText");

                    b.Property<bool>("NameEnabled");

                    b.Property<string>("Subject");

                    b.Property<string>("ThankYouText");

                    b.ToTable("Section_ContactForm");

                    b.HasDiscriminator().HasValue("ContactFormSection");
                });

            modelBuilder.Entity("Wp.Core.Domain.Sections.HtmlContentSection", b =>
                {
                    b.HasBaseType("Wp.Core.Domain.Sections.Section");

                    b.Property<string>("Html")
                        .HasMaxLength(4000);

                    b.ToTable("Section_HtmlContent");

                    b.HasDiscriminator().HasValue("HtmlContentSection");
                });

            modelBuilder.Entity("Wp.Core.Domain.Sections.ResumeSection", b =>
                {
                    b.HasBaseType("Wp.Core.Domain.Sections.Section");

                    b.Property<string>("ApplicationUserName");

                    b.ToTable("Section_Resume");

                    b.HasDiscriminator().HasValue("ResumeSection");
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
                    b.HasOne("Wp.Core.Security.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Wp.Core.Security.ApplicationUser")
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

                    b.HasOne("Wp.Core.Security.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Wp.Core.Security.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.Education", b =>
                {
                    b.HasOne("Wp.Core.Domain.Career.Resume", "Resume")
                        .WithMany("Educations")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.EducationItem", b =>
                {
                    b.HasOne("Wp.Core.Domain.Career.Education", "Education")
                        .WithMany("EducationItems")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.Experience", b =>
                {
                    b.HasOne("Wp.Core.Domain.Career.Resume", "Resume")
                        .WithMany("Experiences")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.Project", b =>
                {
                    b.HasOne("Wp.Core.Domain.Career.Experience", "Experience")
                        .WithMany("Projects")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.Skill", b =>
                {
                    b.HasOne("Wp.Core.Domain.Career.Resume", "Resume")
                        .WithMany("Skills")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wp.Core.Domain.Career.SkillItem", b =>
                {
                    b.HasOne("Wp.Core.Domain.Career.Skill", "Skill")
                        .WithMany("SkillItems")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wp.Core.Domain.Localization.LocaleStringResource", b =>
                {
                    b.HasOne("Wp.Core.Domain.Localization.Language", "Language")
                        .WithMany("LocaleStringResources")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wp.Core.Domain.Localization.LocalizedProperty", b =>
                {
                    b.HasOne("Wp.Core.Domain.Localization.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wp.Core.Domain.Sections.Section", b =>
                {
                    b.HasOne("Wp.Core.Domain.WebPages.WebPage", "WebPage")
                        .WithMany("Sections")
                        .HasForeignKey("WebPageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wp.Core.Domain.WebPages.WebPageRole", b =>
                {
                    b.HasOne("Wp.Core.Domain.WebPages.WebPage", "WebPage")
                        .WithMany("Roles")
                        .HasForeignKey("WebPageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wp.Core.Security.ApplicationUser", b =>
                {
                    b.HasOne("Wp.Core.Domain.Career.Resume", "Resume")
                        .WithMany()
                        .HasForeignKey("ResumeId");
                });
#pragma warning restore 612, 618
        }
    }
}
