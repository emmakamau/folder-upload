using System;
namespace folder_upload.Models;

public class FileItem
{
    public Guid Id { get; set; }
    public string FileName { get; set; }
    public Guid FolderId { get; set; }
    public FolderItem? Folder { get; set; }
}
