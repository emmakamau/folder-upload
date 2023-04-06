using folder_upload.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace folder_upload;

public class FileManagementContext : DbContext
{
    public DbSet<FileItem> FileItems { get; set; }
    public DbSet<FolderItem> FolderItems { get; set; }
    
    public FileManagementContext(DbContextOptions<FileManagementContext> options) : base(options)
    { }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     
    // }
}

