using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FolderTreeTask.Data;

public partial class FoldertaskContext : DbContext
{
    public FoldertaskContext()
    {
    }

    public FoldertaskContext(DbContextOptions<FoldertaskContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Folder> Folders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Folder>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
