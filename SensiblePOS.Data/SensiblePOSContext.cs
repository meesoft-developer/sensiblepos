using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class SensiblePOSContext : DbContext
    {
        string _connectionString = "";
        public SensiblePOSContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SensiblePOSContext(DbContextOptions<SensiblePOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountActiveZone> AccountActiveZones { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<AdminLog> AdminLogs { get; set; }
        public virtual DbSet<CreditCardIssuer> CreditCardIssuers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerTag> CustomerTags { get; set; }
        public virtual DbSet<CustomerTax> CustomerTaxes { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<PrintJob> PrintJobs { get; set; }
        public virtual DbSet<PrintLog> PrintLogs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<PromotionAttachment> PromotionAttachments { get; set; }
        public virtual DbSet<PromotionCondition> PromotionConditions { get; set; }
        public virtual DbSet<PromotionSubSchedule> PromotionSubSchedules { get; set; }
        public virtual DbSet<PromotionUsage> PromotionUsages { get; set; }
        public virtual DbSet<PromotionZone> PromotionZones { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public virtual DbSet<SaleLog> SaleLogs { get; set; }
        public virtual DbSet<StockLog> StockLogs { get; set; }
        public virtual DbSet<SystemInfo> SystemInfos { get; set; }
        public virtual DbSet<Workday> Workdays { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<ZoneAccount> ZoneAccounts { get; set; }
        public virtual DbSet<ZonePrinter> ZonePrinters { get; set; }
        public virtual DbSet<ZoneProduct> ZoneProducts { get; set; }
        public virtual DbSet<ZoneQueue> ZoneQueues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Effective).HasColumnType("datetime");

                entity.Property(e => e.Expire).HasColumnType("datetime");

                entity.Property(e => e.Firstname).HasMaxLength(256);

                entity.Property(e => e.Lastname).HasMaxLength(256);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountActiveZone>(entity =>
            {
                entity.ToTable("AccountActiveZone");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.ToTable("AccountType");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<AdminLog>(entity =>
            {
                entity.ToTable("AdminLog");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Detail).HasMaxLength(2048);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CreditCardIssuer>(entity =>
            {
                entity.ToTable("CreditCardIssuer");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(512);

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(128);

                entity.Property(e => e.Gender).HasDefaultValueSql("((2))");

                entity.Property(e => e.IdCard)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ImageData).HasColumnType("image");

                entity.Property(e => e.LastName).HasMaxLength(128);

                entity.Property(e => e.LastReceipt)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NickName).HasMaxLength(128);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterAddress).HasMaxLength(1024);

                entity.Property(e => e.Title).HasMaxLength(64);
            });

            modelBuilder.Entity<CustomerTag>(entity =>
            {
                entity.ToTable("CustomerTag");

                entity.Property(e => e.CallerNumber)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.TagType)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerTax>(entity =>
            {
                entity.ToTable("CustomerTax");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(512);

                entity.Property(e => e.TaxAddress).HasMaxLength(256);

                entity.Property(e => e.TaxId)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName).HasMaxLength(256);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Msg).HasMaxLength(1024);

                entity.Property(e => e.Reporter)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("Holiday");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.Effective).HasColumnType("datetime");

                entity.Property(e => e.Expire).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.ToTable("Price");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PrintJob>(entity =>
            {
                entity.ToTable("PrintJob");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrintDate).HasColumnType("datetime");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<PrintLog>(entity =>
            {
                entity.ToTable("PrintLog");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Seller)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ImageData).HasColumnType("image");

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.ToTable("Promotion");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Effective).HasColumnType("datetime");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Expire).HasColumnType("datetime");

                entity.Property(e => e.MaximumDc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MaximumDC");

                entity.Property(e => e.PercentDc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PercentDC");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ValueDC");
            });

            modelBuilder.Entity<PromotionAttachment>(entity =>
            {
                entity.ToTable("PromotionAttachment");
            });

            modelBuilder.Entity<PromotionCondition>(entity =>
            {
                entity.ToTable("PromotionCondition");

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(256);
            });

            modelBuilder.Entity<PromotionSubSchedule>(entity =>
            {
                entity.ToTable("PromotionSubSchedule");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PromotionUsage>(entity =>
            {
                entity.ToTable("PromotionUsage");

                entity.Property(e => e.EffectInvoice)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Invoice)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TotalDC");
            });

            modelBuilder.Entity<PromotionZone>(entity =>
            {
                entity.ToTable("PromotionZone");

                entity.Property(e => e.Remarks).HasMaxLength(256);
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.ToTable("Receipt");

                entity.Property(e => e.Change).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Payment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(512);

                entity.Property(e => e.Seller)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StationName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VatPercent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VatType)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.VoidAdmin)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReceiptDetail>(entity =>
            {
                entity.ToTable("ReceiptDetail");

                entity.HasIndex(e => e.SerialNumber, "IX_ReceiptDetail_SerialNumber");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(512);

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SaleLog>(entity =>
            {
                entity.ToTable("SaleLog");

                entity.Property(e => e.Cash).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Promptpay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(1024);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<StockLog>(entity =>
            {
                entity.ToTable("StockLog");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(128);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.StockKey)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SystemInfo>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("SystemInfo");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2048);
            });

            modelBuilder.Entity<Workday>(entity =>
            {
                entity.ToTable("Workday");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HalfTime)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.ToTable("Zone");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(32);
            });

            modelBuilder.Entity<ZoneAccount>(entity =>
            {
                entity.ToTable("ZoneAccount");

                entity.Property(e => e.Effective).HasColumnType("datetime");

                entity.Property(e => e.Expire).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZonePrinter>(entity =>
            {
                entity.ToTable("ZonePrinter");

                entity.Property(e => e.PrinterIp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PrinterIP");
            });

            modelBuilder.Entity<ZoneProduct>(entity =>
            {
                entity.ToTable("ZoneProduct");

                entity.Property(e => e.Category).HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZoneQueue>(entity =>
            {
                entity.ToTable("ZoneQueue");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
