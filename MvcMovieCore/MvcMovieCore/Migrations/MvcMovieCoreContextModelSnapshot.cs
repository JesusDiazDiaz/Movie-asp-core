using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MvcMovieCore.Models;

namespace MvcMovieCore.Migrations
{
    [DbContext(typeof(MvcMovieCoreContext))]
    partial class MvcMovieCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcMovieCore.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FechaLanzamiento");

                    b.Property<string>("Genero");

                    b.Property<decimal>("Precio");

                    b.Property<string>("Titulo");

                    b.HasKey("ID");

                    b.ToTable("Movie");
                });
        }
    }
}
