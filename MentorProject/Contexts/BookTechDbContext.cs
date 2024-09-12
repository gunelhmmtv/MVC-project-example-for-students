using System;
using System.Collections.Generic;
using MentorProject.Tables;
using Microsoft.EntityFrameworkCore;

namespace MentorProject.Contexts;

public partial class BookTechDbContext : DbContext
{
    public BookTechDbContext()
    {
    }

    public BookTechDbContext(DbContextOptions<BookTechDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Writer> Writers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=AURORA\\SQLEXPRESS01;Initial Catalog=BookTechDb; Trusted_Connection=True; TrustServerCertificate= True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
