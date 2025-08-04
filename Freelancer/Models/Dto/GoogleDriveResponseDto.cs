namespace Freelancer.Models.Dto;

public class GoogleDriveResponseDto
{
    public string Kind { get; set; }
    public bool IncompleteSearch { get; set; }
    public IEnumerable<FileDto> Files { get; set; }
    public class FileDto
    {
        public string Kind { get; set; }
        public string DriveId { get; set; }
        public string MimeType { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string TeamDriveId { get; set; }

    }
}