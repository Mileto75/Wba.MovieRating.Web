// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wba.MovieRating.Web.Data;

namespace Wba.MovieRating.Web.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20210401115404_addedSeeding")]
    partial class addedSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.Actor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new { Id = 1L, FirstName = "Keanu", LastName = "Reeves" },
                        new { Id = 2L, FirstName = "Kim", LastName = "Basinger" },
                        new { Id = 3L, FirstName = "Robert", LastName = "De Niro" },
                        new { Id = 4L, FirstName = "Walter", LastName = "Capiau" }
                    );
                });

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new { Id = 1L, Name = "Warner Bros" },
                        new { Id = 2L, Name = "Universal" },
                        new { Id = 3L, Name = "Pixar" }
                    );
                });

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.Director", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new { Id = 1L, FirstName = "Steven", LastName = "Spielberg" },
                        new { Id = 2L, FirstName = "Sly", LastName = "Stallone" },
                        new { Id = 3L, FirstName = "Kathryn", LastName = "Bigelow" }
                    );
                });

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.Movie", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CompanyId");

                    b.Property<DateTime?>("ReleaseDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Movies");

                    b.HasData(
                        new { Id = 1L, CompanyId = 1L, Title = "Point Break" },
                        new { Id = 2L, CompanyId = 2L, Title = "Rocky" },
                        new { Id = 3L, CompanyId = 1L, Title = "Rambo" }
                    );
                });

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.MovieActors", b =>
                {
                    b.Property<long>("ActorId");

                    b.Property<long>("MovieId");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new { ActorId = 1L, MovieId = 1L },
                        new { ActorId = 2L, MovieId = 3L },
                        new { ActorId = 2L, MovieId = 2L },
                        new { ActorId = 3L, MovieId = 3L }
                    );
                });

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.MovieDirectors", b =>
                {
                    b.Property<long>("DirectorId");

                    b.Property<long>("MovieId");

                    b.HasKey("DirectorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieDirectors");

                    b.HasData(
                        new { DirectorId = 1L, MovieId = 1L },
                        new { DirectorId = 2L, MovieId = 2L },
                        new { DirectorId = 3L, MovieId = 3L }
                    );
                });

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.Rating", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("MovieId");

                    b.Property<string>("Review");

                    b.Property<int>("Score");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new { Id = 1L, MovieId = 1L, Review = "Very good! Loved it!", Score = 10, UserId = 1L },
                        new { Id = 2L, MovieId = 3L, Review = "Sucks monkeyballs!", Score = 4, UserId = 2L },
                        new { Id = 3L, MovieId = 3L, Review = "Effing awesome!!", Score = 10, UserId = 2L }
                    );
                });

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasMaxLength(150);

                    b.Property<string>("LastName")
                        .HasMaxLength(150);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1L, FirstName = "Slash", LastName = "Slash", Username = "slash@GandR.com" },
                        new { Id = 2L, FirstName = "John", LastName = "Frusciante", Username = "johnF@RedHotChillis.com" }
                    );
                });

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.Movie", b =>
                {
                    b.HasOne("Wba.MovieRating.Domain.Entities.Company", "Company")
                        .WithMany("Movies")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.MovieActors", b =>
                {
                    b.HasOne("Wba.MovieRating.Domain.Entities.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wba.MovieRating.Domain.Entities.Movie", "Movie")
                        .WithMany("Actors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.MovieDirectors", b =>
                {
                    b.HasOne("Wba.MovieRating.Domain.Entities.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wba.MovieRating.Domain.Entities.Movie", "Movie")
                        .WithMany("Directors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wba.MovieRating.Domain.Entities.Rating", b =>
                {
                    b.HasOne("Wba.MovieRating.Domain.Entities.Movie", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wba.MovieRating.Domain.Entities.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
