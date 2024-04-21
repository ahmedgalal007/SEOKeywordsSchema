﻿// <auto-generated />
using System;
using Host.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Host.Migrations.Application
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240421232700_schemavalues")]
    partial class schemavalues
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.AdditionalType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("HasValue1")
                        .HasColumnType("bit");

                    b.Property<bool>("HasValue2")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSingle")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("AdditionalType", "Schema.Property");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes.OwnedBaseTypes.Text", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdditionalTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalTypeId");

                    b.ToTable("Text", "Schema.Property");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes.URL", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdditionalTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MainEntityOfPageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubjectOfId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalTypeId");

                    b.HasIndex("ImageId");

                    b.HasIndex("MainEntityOfPageId");

                    b.HasIndex("SubjectOfId");

                    b.ToTable("URL", "Schema.Property");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("HasValue1")
                        .HasColumnType("bit");

                    b.Property<bool>("HasValue2")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSingle")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Image", "Schema.Property");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.MainEntityOfPage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("HasValue1")
                        .HasColumnType("bit");

                    b.Property<bool>("HasValue2")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSingle")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MainEntityOfPage", "Schema.Property");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.SubjectOf", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("HasValue1")
                        .HasColumnType("bit");

                    b.Property<bool>("HasValue2")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSingle")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SubjectOf", "Schema.Property");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.Things.CreativeWork", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MainEntityOfPageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubjectOfId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainEntityOfPageId");

                    b.HasIndex("ParentId");

                    b.HasIndex("SubjectOfId");

                    b.ToTable("CreativeWork", "Schema");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.Things.CreativeWorks.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Article", "Schema");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.Things.CreativeWorks.MediaObject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("MediaObject", "Schema");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.Things.CreativeWorks.MediaObjects.ImageObject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("ParentId");

                    b.ToTable("ImageObject", "Schema");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.Things.Thing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdditionalTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DisambiguatingDescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Identifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MainEntityOfPageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("NameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PotentialAction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SameAsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubjectOfId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UrlId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalTypeId");

                    b.HasIndex("DisambiguatingDescriptionId");

                    b.HasIndex("ImageId");

                    b.HasIndex("MainEntityOfPageId");

                    b.HasIndex("NameId");

                    b.HasIndex("SameAsId");

                    b.HasIndex("SubjectOfId");

                    b.HasIndex("UrlId");

                    b.ToTable("Thing", "Schema");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes.OwnedBaseTypes.Text", b =>
                {
                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.AdditionalType", null)
                        .WithMany("Value1")
                        .HasForeignKey("AdditionalTypeId");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes.URL", b =>
                {
                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.AdditionalType", null)
                        .WithMany("Value2")
                        .HasForeignKey("AdditionalTypeId");

                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.Image", null)
                        .WithMany("Value2")
                        .HasForeignKey("ImageId");

                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.MainEntityOfPage", null)
                        .WithMany("Value2")
                        .HasForeignKey("MainEntityOfPageId");

                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.SubjectOf", null)
                        .WithMany("Value2")
                        .HasForeignKey("SubjectOfId");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.Things.CreativeWork", b =>
                {
                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.MainEntityOfPage", null)
                        .WithMany("Value1")
                        .HasForeignKey("MainEntityOfPageId");

                    b.HasOne("SEOKeywordsSchema.Schemas.Things.Thing", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.SubjectOf", null)
                        .WithMany("Value1")
                        .HasForeignKey("SubjectOfId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.Things.CreativeWorks.Article", b =>
                {
                    b.HasOne("SEOKeywordsSchema.Schemas.Things.CreativeWork", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.Things.CreativeWorks.MediaObject", b =>
                {
                    b.HasOne("SEOKeywordsSchema.Schemas.Things.CreativeWork", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.Things.CreativeWorks.MediaObjects.ImageObject", b =>
                {
                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.Image", null)
                        .WithMany("Value1")
                        .HasForeignKey("ImageId");

                    b.HasOne("SEOKeywordsSchema.Schemas.Things.CreativeWorks.MediaObject", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.Things.Thing", b =>
                {
                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.AdditionalType", "AdditionalType")
                        .WithMany()
                        .HasForeignKey("AdditionalTypeId");

                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes.OwnedBaseTypes.Text", "DisambiguatingDescription")
                        .WithMany()
                        .HasForeignKey("DisambiguatingDescriptionId");

                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.MainEntityOfPage", "MainEntityOfPage")
                        .WithMany()
                        .HasForeignKey("MainEntityOfPageId");

                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes.OwnedBaseTypes.Text", "Name")
                        .WithMany()
                        .HasForeignKey("NameId");

                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes.URL", "SameAs")
                        .WithMany()
                        .HasForeignKey("SameAsId");

                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.SubjectOf", "SubjectOf")
                        .WithMany()
                        .HasForeignKey("SubjectOfId");

                    b.HasOne("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes.URL", "Url")
                        .WithMany()
                        .HasForeignKey("UrlId");

                    b.Navigation("AdditionalType");

                    b.Navigation("DisambiguatingDescription");

                    b.Navigation("Image");

                    b.Navigation("MainEntityOfPage");

                    b.Navigation("Name");

                    b.Navigation("SameAs");

                    b.Navigation("SubjectOf");

                    b.Navigation("Url");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.AdditionalType", b =>
                {
                    b.Navigation("Value1");

                    b.Navigation("Value2");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.Image", b =>
                {
                    b.Navigation("Value1");

                    b.Navigation("Value2");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.MainEntityOfPage", b =>
                {
                    b.Navigation("Value1");

                    b.Navigation("Value2");
                });

            modelBuilder.Entity("SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.SubjectOf", b =>
                {
                    b.Navigation("Value1");

                    b.Navigation("Value2");
                });
#pragma warning restore 612, 618
        }
    }
}
