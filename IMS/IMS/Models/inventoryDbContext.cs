using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IMS.Models
{
    public partial class inventoryDbContext : DbContext
    {
        public inventoryDbContext()
        {
        }

        public inventoryDbContext(DbContextOptions<inventoryDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Offer> Offers { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Purchase> Purchases { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SalesDetail> SalesDetails { get; set; } = null!;
        public virtual DbSet<SalesReturn> SalesReturns { get; set; } = null!;
        public virtual DbSet<SalesReturnRatio> SalesReturnRatios { get; set; } = null!;
        public virtual DbSet<Stock> Stocks { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.; Database=inventoryDb; Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contact)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contact");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndingDate)
                    .HasColumnType("date")
                    .HasColumnName("endingDate");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.StartingDate)
                    .HasColumnType("date")
                    .HasColumnName("startingDate");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Expirydate)
                    .HasColumnType("date")
                    .HasColumnName("expirydate");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Categoryid)
                    .HasConstraintName("FK__Product__categor__2E1BDC42");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.ToTable("Purchase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.PricePerUnit).HasColumnName("pricePerUnit");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SupplierId).HasColumnName("supplierId");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("money")
                    .HasColumnName("totalAmount");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Purchase__produc__36B12243");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__Purchase__suppli__37A5467C");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("money")
                    .HasColumnName("totalAmount");

                entity.Property(e => e.TotalDiscount)
                    .HasColumnType("money")
                    .HasColumnName("totalDiscount");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Sales__employeeI__3C69FB99");
            });

            modelBuilder.Entity<SalesDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SalesId).HasColumnName("salesId");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("money")
                    .HasColumnName("totalAmount");

                entity.Property(e => e.TotalDiscount)
                    .HasColumnType("money")
                    .HasColumnName("totalDiscount");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__SalesDeta__produ__403A8C7D");

                entity.HasOne(d => d.Sales)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.SalesId)
                    .HasConstraintName("FK__SalesDeta__sales__3F466844");
            });

            modelBuilder.Entity<SalesReturn>(entity =>
            {
                entity.ToTable("SalesReturn");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmountReturned)
                    .HasColumnType("money")
                    .HasColumnName("amountReturned");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SalesId).HasColumnName("salesId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SalesReturns)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__SalesRetu__produ__440B1D61");

                entity.HasOne(d => d.Sales)
                    .WithMany(p => p.SalesReturns)
                    .HasForeignKey(d => d.SalesId)
                    .HasConstraintName("FK__SalesRetu__sales__4316F928");
            });

            modelBuilder.Entity<SalesReturnRatio>(entity =>
            {
                entity.ToTable("SalesReturnRatio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ratio)
                    .HasColumnType("money")
                    .HasColumnName("ratio");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("Stock");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Stock__productId__32E0915F");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Companyname)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("companyname");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contactNo");

                entity.Property(e => e.RegestrationNo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("regestrationNo");

                entity.Property(e => e.SupplierContact)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("supplierContact");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplierName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
