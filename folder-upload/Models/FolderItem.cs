using System;
namespace folder_upload.Models;

public class FolderItem:IResource
{
    public Guid Id { get; set; }
    public ResourcePath Path { get; set; }
    public bool IsUserUploaded { get; set; }

    public string Name => Path.FolderName;
    public ResourceType Type => ResourceType.Folder;
}


public enum ResourceType
{
    Folder,
    File
}

public abstract class ResourcePath
{
    public string FullPath { get; set; }
    public string FolderName { get; set; }
    public string FileName { get; set; }
    // Other properties as needed
}