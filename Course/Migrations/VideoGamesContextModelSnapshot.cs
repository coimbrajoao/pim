﻿// <auto-generated />
using System;
using Course;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Course.Migrations
{
    [DbContext(typeof(VideoGamesContext))]
    partial class VideoGamesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("Course.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("GameName")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("game_name");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int")
                        .HasColumnName("genre_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "GenreId" }, "fk_gm_gen");

                    b.ToTable("game", (string)null);
                });

            modelBuilder.Entity("Course.GamePlatform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("GamePublisherId")
                        .HasColumnType("int")
                        .HasColumnName("game_publisher_id");

                    b.Property<int?>("PlatformId")
                        .HasColumnType("int")
                        .HasColumnName("platform_id");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("int")
                        .HasColumnName("release_year");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "GamePublisherId" }, "fk_gpl_gp");

                    b.HasIndex(new[] { "PlatformId" }, "fk_gpl_pla");

                    b.ToTable("game_platform", (string)null);
                });

            modelBuilder.Entity("Course.GamePublisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("game_id");

                    b.Property<int?>("PublisherId")
                        .HasColumnType("int")
                        .HasColumnName("publisher_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "GameId" }, "fk_gpu_gam");

                    b.HasIndex(new[] { "PublisherId" }, "fk_gpu_pub");

                    b.ToTable("game_publisher", (string)null);
                });

            modelBuilder.Entity("Course.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("GenreName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("genre_name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("genre", (string)null);
                });

            modelBuilder.Entity("Course.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("PlatformName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("platform_name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("platform", (string)null);
                });

            modelBuilder.Entity("Course.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("PublisherName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("publisher_name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("publisher", (string)null);
                });

            modelBuilder.Entity("Course.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("RegionName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("region_name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("region", (string)null);
                });

            modelBuilder.Entity("Course.RegionSale", b =>
                {
                    b.Property<int?>("GamePlatformId")
                        .HasColumnType("int")
                        .HasColumnName("game_platform_id");

                    b.Property<decimal?>("NumSales")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("num_sales");

                    b.Property<int?>("RegionId")
                        .HasColumnType("int")
                        .HasColumnName("region_id");

                    b.HasIndex(new[] { "GamePlatformId" }, "fk_rs_gp");

                    b.HasIndex(new[] { "RegionId" }, "fk_rs_reg");

                    b.ToTable("region_sales", (string)null);
                });

            modelBuilder.Entity("Course.Game", b =>
                {
                    b.HasOne("Course.Genre", "Genre")
                        .WithMany("Games")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_gm_gen");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Course.GamePlatform", b =>
                {
                    b.HasOne("Course.GamePublisher", "GamePublisher")
                        .WithMany("GamePlatforms")
                        .HasForeignKey("GamePublisherId")
                        .HasConstraintName("fk_gpl_gp");

                    b.HasOne("Course.Platform", "Platform")
                        .WithMany("GamePlatforms")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_gpl_pla");

                    b.Navigation("GamePublisher");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("Course.GamePublisher", b =>
                {
                    b.HasOne("Course.Game", "Game")
                        .WithMany("GamePublishers")
                        .HasForeignKey("GameId")
                        .HasConstraintName("fk_gpu_gam");

                    b.HasOne("Course.Publisher", "Publisher")
                        .WithMany("GamePublishers")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_gpu_pub");

                    b.Navigation("Game");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Course.RegionSale", b =>
                {
                    b.HasOne("Course.GamePlatform", "GamePlatform")
                        .WithMany()
                        .HasForeignKey("GamePlatformId")
                        .HasConstraintName("fk_rs_gp");

                    b.HasOne("Course.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .HasConstraintName("fk_rs_reg");

                    b.Navigation("GamePlatform");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Course.Game", b =>
                {
                    b.Navigation("GamePublishers");
                });

            modelBuilder.Entity("Course.GamePublisher", b =>
                {
                    b.Navigation("GamePlatforms");
                });

            modelBuilder.Entity("Course.Genre", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("Course.Platform", b =>
                {
                    b.Navigation("GamePlatforms");
                });

            modelBuilder.Entity("Course.Publisher", b =>
                {
                    b.Navigation("GamePublishers");
                });
#pragma warning restore 612, 618
        }
    }
}
