using System;
using System.Collections.Generic;
using FilmesMoura.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesMoura.WebAPI.BdContextFilme;

public partial class FilmesContext : DbContext
{
    public FilmesContext()
    {
    }

    public FilmesContext(DbContextOptions<FilmesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Filme> Filmes { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FilmesBD;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Filme>(entity =>
        {
            entity.HasKey(e => e.IdFilme).HasName("PK__Filme__6E8F2A7662EEE76C");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Filmes).HasConstraintName("FK__Filme__IdGenero__5EBF139D");
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.HasKey(e => e.IdGenero).HasName("PK__Genero__0F8349883625A11E");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF977C51206F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
