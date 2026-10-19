using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QL_DaNgoai.Models;

public partial class QL_DaNgoaiContext : DbContext
{
    public QL_DaNgoaiContext(DbContextOptions<QL_DaNgoaiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChuyenDi> ChuyenDis { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChuyenDi>(entity =>
        {
            entity.HasKey(e => e.MaChuyen).HasName("PK__ChuyenDi__0ED32A47EA354255");

            entity.ToTable("ChuyenDi");

            entity.Property(e => e.DiaDiem).HasMaxLength(100);
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.NganSach).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PhuongTien).HasMaxLength(30);
            entity.Property(e => e.TenChuyen).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
