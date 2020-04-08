using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QLCHXe.Models
{
    public partial class QLCHXeContext : DbContext
    {
        public QLCHXeContext()
        {
        }

        public QLCHXeContext(DbContextOptions<QLCHXeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acccount> Acccount { get; set; }
        public virtual DbSet<BaoHanh> BaoHanh { get; set; }
        public virtual DbSet<CtHdn> CtHdn { get; set; }
        public virtual DbSet<CtHdx> CtHdx { get; set; }
        public virtual DbSet<CtKho> CtKho { get; set; }
        public virtual DbSet<Hdn> Hdn { get; set; }
        public virtual DbSet<Hdx> Hdx { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<Kho> Kho { get; set; }
        public virtual DbSet<LoaiXe> LoaiXe { get; set; }
        public virtual DbSet<Ncc> Ncc { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<Xe> Xe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=QLCHXe;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acccount>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK_Table_1");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<BaoHanh>(entity =>
            {
                entity.HasKey(e => e.MaBh);

                entity.Property(e => e.MaBh)
                    .HasColumnName("MaBH")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.NgayMua).HasColumnType("date");

                entity.Property(e => e.ThoiGianBh)
                    .HasColumnName("ThoiGianBH")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.BaoHanh)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_BaoHanh_KhachHang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.BaoHanh)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_BaoHanh_NhanVien");

                entity.HasOne(d => d.MaXeNavigation)
                    .WithMany(p => p.BaoHanh)
                    .HasForeignKey(d => d.MaXe)
                    .HasConstraintName("FK_BaoHanh_Xe");
            });

            modelBuilder.Entity<CtHdn>(entity =>
            {
                entity.ToTable("CT_HDN");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaHdn).HasColumnName("MaHDN");

                entity.Property(e => e.MaKho).HasColumnName("maKho");

                entity.Property(e => e.ThueVat).HasColumnName("ThueVAT");

                entity.HasOne(d => d.MaHdnNavigation)
                    .WithMany(p => p.CtHdn)
                    .HasForeignKey(d => d.MaHdn)
                    .HasConstraintName("FK_CT_HDN_HDN");

                entity.HasOne(d => d.MaKhoNavigation)
                    .WithMany(p => p.CtHdn)
                    .HasForeignKey(d => d.MaKho)
                    .HasConstraintName("FK_CT_HDN_Kho");

                entity.HasOne(d => d.MaXeNavigation)
                    .WithMany(p => p.CtHdn)
                    .HasForeignKey(d => d.MaXe)
                    .HasConstraintName("FK_CT_HDN_Xe");
            });

            modelBuilder.Entity<CtHdx>(entity =>
            {
                entity.ToTable("CT_HDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaHdx).HasColumnName("MaHDX");

                entity.Property(e => e.MaKho).HasColumnName("maKho");

                entity.Property(e => e.SoKhung).HasMaxLength(50);

                entity.Property(e => e.SoMay).HasMaxLength(50);

                entity.Property(e => e.ThueVat).HasColumnName("ThueVAT");

                entity.HasOne(d => d.MaHdxNavigation)
                    .WithMany(p => p.CtHdx)
                    .HasForeignKey(d => d.MaHdx)
                    .HasConstraintName("FK_CT_HDX_HDX");

                entity.HasOne(d => d.MaKhoNavigation)
                    .WithMany(p => p.CtHdx)
                    .HasForeignKey(d => d.MaKho)
                    .HasConstraintName("FK_CT_HDX_Kho");

                entity.HasOne(d => d.MaXeNavigation)
                    .WithMany(p => p.CtHdx)
                    .HasForeignKey(d => d.MaXe)
                    .HasConstraintName("FK_CT_HDX_Xe");
            });

            modelBuilder.Entity<CtKho>(entity =>
            {
                entity.ToTable("CT_Kho");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaKho).HasColumnName("maKho");

                entity.Property(e => e.MaXe).HasColumnName("maXe");

                entity.Property(e => e.Soluong).HasColumnName("soluong");

                entity.HasOne(d => d.MaKhoNavigation)
                    .WithMany(p => p.CtKho)
                    .HasForeignKey(d => d.MaKho)
                    .HasConstraintName("FK_CT_Kho_Kho");

                entity.HasOne(d => d.MaXeNavigation)
                    .WithMany(p => p.CtKho)
                    .HasForeignKey(d => d.MaXe)
                    .HasConstraintName("FK_CT_Kho_Xe");
            });

            modelBuilder.Entity<Hdn>(entity =>
            {
                entity.HasKey(e => e.MaHdn);

                entity.ToTable("HDN");

                entity.Property(e => e.MaHdn)
                    .HasColumnName("MaHDN")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaNcc).HasColumnName("MaNCC");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.NgayNhap).HasColumnType("date");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.Hdn)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK_HDN_NCC");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Hdn)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_HDN_NhanVien");
            });

            modelBuilder.Entity<Hdx>(entity =>
            {
                entity.HasKey(e => e.MaHdx);

                entity.ToTable("HDX");

                entity.Property(e => e.MaHdx)
                    .HasColumnName("MaHDX")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.NgayXuat).HasColumnType("date");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Hdx)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_HDX_KhachHang");

                entity.HasOne(d => d.MaNv1)
                    .WithMany(p => p.Hdx)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_HDX_NhanVien");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cmnd)
                    .HasColumnName("CMND")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenKh)
                    .HasColumnName("TenKH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Kho>(entity =>
            {
                entity.HasKey(e => e.MaKho);

                entity.Property(e => e.MaKho)
                    .HasColumnName("maKho")
                    .ValueGeneratedNever();

                entity.Property(e => e.TenKho)
                    .HasColumnName("tenKho")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiXe>(entity =>
            {
                entity.HasKey(e => e.MaLoaiXe);

                entity.Property(e => e.MaLoaiXe).ValueGeneratedNever();

                entity.Property(e => e.TenLoaiXe).HasMaxLength(50);
            });

            modelBuilder.Entity<Ncc>(entity =>
            {
                entity.HasKey(e => e.MaNcc);

                entity.ToTable("NCC");

                entity.Property(e => e.MaNcc)
                    .HasColumnName("MaNCC")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TenNcc)
                    .HasColumnName("TenNCC")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChucVu).HasMaxLength(50);

                entity.Property(e => e.Cmnd)
                    .HasColumnName("CMND")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenNv)
                    .HasColumnName("TenNV")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Xe>(entity =>
            {
                entity.HasKey(e => e.MaXe);

                entity.Property(e => e.MaXe).ValueGeneratedNever();

                entity.Property(e => e.MaNcc).HasColumnName("MaNCC");

                entity.Property(e => e.Mau).HasMaxLength(50);

                entity.Property(e => e.TenXe).HasMaxLength(50);

                entity.HasOne(d => d.MaLoaiXeNavigation)
                    .WithMany(p => p.Xe)
                    .HasForeignKey(d => d.MaLoaiXe)
                    .HasConstraintName("FK_Xe_LoaiXe");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.Xe)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK_Xe_NCC1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
