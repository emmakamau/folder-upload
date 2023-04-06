using System;
namespace folder_upload.Models;

public class FileItem : IResource
{
    public Guid Id { get; set;}
    public ResourcePath Path { get; set; }
    public bool IsUserUploaded { get; set; }

    public string Name => Path.FileName;
    public ResourceType Type => ResourceType.File;
}
