using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FilmLabShop.Models.db;

public partial class FilmLabDbContext : DbContext
{
    public FilmLabDbContext()
    {
    }

    public FilmLabDbContext(DbContextOptions<FilmLabDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbAdminstrator> TbAdminstrators { get; set; }

    public virtual DbSet<TbBill> TbBills { get; set; }

    public virtual DbSet<TbCart> TbCarts { get; set; }

    public virtual DbSet<TbCategory> TbCategories { get; set; }

    public virtual DbSet<TbCustomer> TbCustomers { get; set; }

    public virtual DbSet<TbProduct> TbProducts { get; set; }

    public virtual DbSet<TbReview> TbReviews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=FilmLabDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbAdminstrator>(entity =>
        {
            entity.HasKey(e => e.AdminId);

            entity.ToTable("TbAdminstrator");

            entity.Property(e => e.AdminId).ValueGeneratedNever();
            entity.Property(e => e.AdminName).HasMaxLength(50);
            entity.Property(e => e.AdminPw).HasMaxLength(50);
        });

        modelBuilder.Entity<TbBill>(entity =>
        {
            entity.HasKey(e => e.BillId).HasName("PK_TbBill_1");

            entity.ToTable("TbBill");

            entity.Property(e => e.BillId).ValueGeneratedNever();
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.PdName).HasMaxLength(50);

            entity.HasOne(d => d.Cus).WithMany(p => p.TbBills)
                .HasForeignKey(d => d.CusId)
                .HasConstraintName("FK_TbBill_TbCustomer");

            entity.HasOne(d => d.Pd).WithMany(p => p.TbBills)
                .HasForeignKey(d => d.PdId)
                .HasConstraintName("FK_TbBill_TbProduct");
        });

        modelBuilder.Entity<TbCart>(entity =>
        {
            entity.HasKey(e => e.CartId);

            entity.ToTable("TbCart");

            entity.Property(e => e.CartId).ValueGeneratedNever();
            entity.Property(e => e.CartName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbCategory>(entity =>
        {
            entity.HasKey(e => e.CateId);

            entity.ToTable("TbCategory");

            entity.Property(e => e.CateId).ValueGeneratedNever();
            entity.Property(e => e.CateName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbCustomer>(entity =>
        {
            entity.HasKey(e => e.CusId);

            entity.ToTable("TbCustomer");

            entity.Property(e => e.CusId).ValueGeneratedNever();
            entity.Property(e => e.CusAddress).HasMaxLength(50);
            entity.Property(e => e.CusEmail).HasMaxLength(50);
            entity.Property(e => e.CusName).HasMaxLength(50);
            entity.Property(e => e.CusPhone).HasMaxLength(50);
        });

        modelBuilder.Entity<TbProduct>(entity =>
        {
            entity.HasKey(e => e.PdId);

            entity.ToTable("TbProduct");

            entity.Property(e => e.PdId).ValueGeneratedNever();
            entity.Property(e => e.PdDetail).HasMaxLength(50);
            entity.Property(e => e.PdName).HasMaxLength(50);
            entity.Property(e => e.PdStatus).HasMaxLength(50);
            entity.Property(e => e.PdSubHead).HasMaxLength(50);

            entity.HasOne(d => d.Cate).WithMany(p => p.TbProducts)
                .HasForeignKey(d => d.CateId)
                .HasConstraintName("FK_TbProduct_TbCategory");
        });

        modelBuilder.Entity<TbReview>(entity =>
        {
            entity.HasKey(e => e.RevId);

            entity.ToTable("TbReview");

            entity.Property(e => e.RevId).ValueGeneratedNever();
            entity.Property(e => e.PdName).HasMaxLength(50);
            entity.Property(e => e.RevDate).HasColumnType("datetime");
            entity.Property(e => e.RevMessage).HasMaxLength(50);
            entity.Property(e => e.RevTitle).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
