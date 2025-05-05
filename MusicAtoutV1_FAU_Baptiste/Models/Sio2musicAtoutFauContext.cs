using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MusicAtoutV1_FAU_Baptiste.Models;

public partial class Sio2musicAtoutFauContext : DbContext
{
    public Sio2musicAtoutFauContext()
    {
    }

    public Sio2musicAtoutFauContext(DbContextOptions<Sio2musicAtoutFauContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Batiment> Batiments { get; set; }

    public virtual DbSet<Compositeur> Compositeurs { get; set; }

    public virtual DbSet<Nationalite> Nationalites { get; set; }

    public virtual DbSet<Oeuvre> Oeuvres { get; set; }

    public virtual DbSet<Salle> Salles { get; set; }

    public virtual DbSet<Style> Styles { get; set; }

    public virtual DbSet<Typeoeuvre> Typeoeuvres { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    public virtual DbSet<Ville> Villes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=ST201\\SQLSERVER;Initial Catalog=SIO2MusicAtout_FAU;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Batiment>(entity =>
        {
            entity.HasKey(e => e.IdBati);

            entity.ToTable("BATIMENT");

            entity.Property(e => e.IdBati).HasColumnName("idBati");
            entity.Property(e => e.AnConstruction).HasColumnName("anConstruction");
            entity.Property(e => e.CpBati).HasColumnName("cpBati");
            entity.Property(e => e.IdVille).HasColumnName("idVille");
            entity.Property(e => e.NomBati)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nomBati");
            entity.Property(e => e.Responsable)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsable");
            entity.Property(e => e.RueBati)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("rueBati");
            entity.Property(e => e.TelBati)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telBati");

            entity.HasOne(d => d.IdVilleNavigation).WithMany(p => p.Batiments)
                .HasForeignKey(d => d.IdVille)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BATIMENT_VILLE");
        });

        modelBuilder.Entity<Compositeur>(entity =>
        {
            entity.HasKey(e => e.IdCompositeur);

            entity.ToTable("COMPOSITEUR");

            entity.Property(e => e.IdCompositeur).HasColumnName("idCompositeur");
            entity.Property(e => e.AnMort).HasColumnName("anMort");
            entity.Property(e => e.AnNais).HasColumnName("anNais");
            entity.Property(e => e.IdNation).HasColumnName("idNation");
            entity.Property(e => e.IdStyle).HasColumnName("idStyle");
            entity.Property(e => e.NomCompositeur)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nomCompositeur");
            entity.Property(e => e.PrenomCompositeur)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("prenomCompositeur");
            entity.Property(e => e.Remarque)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("remarque");

            entity.HasOne(d => d.IdNationNavigation).WithMany(p => p.Compositeurs)
                .HasForeignKey(d => d.IdNation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPOSITEUR_NATIONALITE");

            entity.HasOne(d => d.IdStyleNavigation).WithMany(p => p.Compositeurs)
                .HasForeignKey(d => d.IdStyle)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPOSITEUR_STYLE");
        });

        modelBuilder.Entity<Nationalite>(entity =>
        {
            entity.HasKey(e => e.IdNation);

            entity.ToTable("NATIONALITE");

            entity.Property(e => e.IdNation).HasColumnName("idNation");
            entity.Property(e => e.LibNation)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("libNation");
        });

        modelBuilder.Entity<Oeuvre>(entity =>
        {
            entity.HasKey(e => e.IdOeuvre);

            entity.ToTable("OEUVRE");

            entity.Property(e => e.IdOeuvre).HasColumnName("idOeuvre");
            entity.Property(e => e.AnComposition).HasColumnName("anComposition");
            entity.Property(e => e.IdCompositeur).HasColumnName("idCompositeur");
            entity.Property(e => e.IdType).HasColumnName("idType");
            entity.Property(e => e.Texte)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("texte");
            entity.Property(e => e.TitreOeuvre)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("titreOeuvre");

            entity.HasOne(d => d.IdCompositeurNavigation).WithMany(p => p.Oeuvres)
                .HasForeignKey(d => d.IdCompositeur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OEUVRE_COMPOSITEUR");

            entity.HasOne(d => d.IdTypeNavigation).WithMany(p => p.Oeuvres)
                .HasForeignKey(d => d.IdType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OEUVRE_TYPE");
        });

        modelBuilder.Entity<Salle>(entity =>
        {
            entity.HasKey(e => new { e.IdBati, e.NumSalle });

            entity.ToTable("SALLE");

            entity.Property(e => e.IdBati).HasColumnName("idBati");
            entity.Property(e => e.NumSalle).HasColumnName("numSalle");
            entity.Property(e => e.Capacite).HasColumnName("capacite");
            entity.Property(e => e.NomSalle)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nomSalle");
            entity.Property(e => e.Superficie).HasColumnName("superficie");

            entity.HasOne(d => d.IdBatiNavigation).WithMany(p => p.Salles)
                .HasForeignKey(d => d.IdBati)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SALLE_BATIMENT");

            entity.HasMany(d => d.IdTypes).WithMany(p => p.Salles)
                .UsingEntity<Dictionary<string, object>>(
                    "Accueillir",
                    r => r.HasOne<Typeoeuvre>().WithMany()
                        .HasForeignKey("IdType")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TYPEOEUVRE"),
                    l => l.HasOne<Salle>().WithMany()
                        .HasForeignKey("IdBati", "NumSalle")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SALLE"),
                    j =>
                    {
                        j.HasKey("IdBati", "NumSalle", "IdType");
                        j.ToTable("ACCUEILLIR");
                        j.IndexerProperty<int>("IdBati").HasColumnName("idBati");
                        j.IndexerProperty<int>("NumSalle").HasColumnName("numSalle");
                        j.IndexerProperty<int>("IdType").HasColumnName("idType");
                    });
        });

        modelBuilder.Entity<Style>(entity =>
        {
            entity.HasKey(e => e.IdStyle);

            entity.ToTable("STYLE");

            entity.Property(e => e.IdStyle).HasColumnName("idStyle");
            entity.Property(e => e.DateDebut).HasColumnName("dateDebut");
            entity.Property(e => e.DateFin).HasColumnName("dateFin");
            entity.Property(e => e.LibStyle)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("libStyle");
        });

        modelBuilder.Entity<Typeoeuvre>(entity =>
        {
            entity.HasKey(e => e.IdType).HasName("PK_TYPE");

            entity.ToTable("TYPEOEUVRE");

            entity.Property(e => e.IdType).HasColumnName("idType");
            entity.Property(e => e.LibelleType)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("libelleType");
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.HasKey(e => e.IdUtilisateur).HasName("PK__UTILISAT__5366DB193C0983D5");

            entity.ToTable("UTILISATEUR");

            entity.Property(e => e.IdUtilisateur)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idUtilisateur");
            entity.Property(e => e.Actif).HasColumnName("actif");
            entity.Property(e => e.Droits).HasColumnName("droits");
            entity.Property(e => e.Nbessais).HasColumnName("nbessais");
            entity.Property(e => e.Passwd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("passwd");
        });

        modelBuilder.Entity<Ville>(entity =>
        {
            entity.HasKey(e => e.IdVille);

            entity.ToTable("VILLE");

            entity.Property(e => e.IdVille).HasColumnName("idVille");
            entity.Property(e => e.Departement).HasColumnName("departement");
            entity.Property(e => e.NomVille)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nomVille");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
