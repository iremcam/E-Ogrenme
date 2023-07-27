using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfinityProject.Models
{
    public partial class InfinityContext : DbContext
    {
        public InfinityContext()
        {
        }

        public InfinityContext(DbContextOptions<InfinityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciTipi> KullaniciTipi { get; set; }
        public virtual DbSet<Secenek> Secenek { get; set; }
        public virtual DbSet<Sinav> Sinav { get; set; }
        public virtual DbSet<SinavKullanici> SinavKullanici { get; set; }
        public virtual DbSet<Soru> Soru { get; set; }
        public virtual DbSet<SoruTipi> SoruTipi { get; set; }
        public virtual DbSet<Cozum> Cozum { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-2PGSHUI\\SQLEXPRESS;User ID=sa;Password=1234;Database=Infinity;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.Property(e => e.KategoriAdi)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.Property(e => e.KullaniciAdi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sifre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.KullaniciTip)
                    .WithMany(p => p.Kullanici)
                    .HasForeignKey(d => d.KullaniciTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kullanici_KullaniciTipi");
            });

            modelBuilder.Entity<KullaniciTipi>(entity =>
            {
                entity.Property(e => e.KullaniciTipAdi).HasMaxLength(100);
            });

            modelBuilder.Entity<Secenek>(entity =>
            {
                entity.Property(e => e.DogruSecenek)
                    .IsRequired()
                    .IsFixedLength();

                entity.Property(e => e.SecenekAciklamasi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Soru)
                    .WithMany(p => p.Secenek)
                    .HasForeignKey(d => d.SoruId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Secenek_Soru");
            });

            modelBuilder.Entity<Sinav>(entity =>
            {
                entity.Property(e => e.SinavAdi)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SinavKullanici>(entity =>
            {
                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.SinavKullanici)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SinavKullanici_Kullanici");

                entity.HasOne(d => d.Sinav)
                    .WithMany(p => p.SinavKullanici)
                    .HasForeignKey(d => d.SinavId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SinavKullanici_Sinav");
            });

            modelBuilder.Entity<Soru>(entity =>
            {
                entity.Property(e => e.Icerik).IsRequired();

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.Soru)
                    .HasForeignKey(d => d.KategoriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Soru_Kategori");

                entity.HasOne(d => d.Sinav)
                    .WithMany(p => p.Soru)
                    .HasForeignKey(d => d.SinavId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Soru_Sinav");

                entity.HasOne(d => d.SoruTipi)
                    .WithMany(p => p.Soru)
                    .HasForeignKey(d => d.SoruTipiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Soru_SoruTipi");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
