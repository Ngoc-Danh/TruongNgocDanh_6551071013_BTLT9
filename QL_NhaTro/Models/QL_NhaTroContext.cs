using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QL_NhaTro.Models;

public partial class QL_NhaTroContext : DbContext
{
    public QL_NhaTroContext(DbContextOptions<QL_NhaTroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<KhachThue> KhachThues { get; set; }

    public virtual DbSet<PhongTro> PhongTros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KhachThue>(entity =>
        {
            entity.HasKey(e => e.MaKhach).HasName("PK__KhachThu__D0CB8DDD756AE710");

            entity.ToTable("KhachThue");

            entity.Property(e => e.GioiTinh).HasMaxLength(5);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TenPhuongXa).HasMaxLength(100);
            entity.Property(e => e.TenTinh).HasMaxLength(100);

            entity.HasOne(d => d.MaPhongNavigation).WithMany(p => p.KhachThues)
                .HasForeignKey(d => d.MaPhong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KhachThue__MaPho__4E88ABD4");
        });

        modelBuilder.Entity<PhongTro>(entity =>
        {
            entity.HasKey(e => e.MaPhong).HasName("PK__PhongTro__20BD5E5B57AD1BB5");

            entity.ToTable("PhongTro");

            entity.Property(e => e.GiaThue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TenPhong).HasMaxLength(20);
            entity.Property(e => e.TinhTrang)
                .HasMaxLength(20)
                .HasDefaultValue("Trá»‘ng");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
