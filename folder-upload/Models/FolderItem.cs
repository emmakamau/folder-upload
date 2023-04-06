using System;
namespace folder_upload.Models;

public class FolderItem
{
    public Guid Id { get; set; }
    public string FolderName { get; set; }
    public ICollection<FileItem> Files { get; set; }
}

