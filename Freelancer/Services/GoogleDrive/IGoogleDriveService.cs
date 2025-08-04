using Freelancer.Models.Dto;

namespace Freelancer.Services.GoogleDrive;

public interface IGoogleDriveService
{
    Task<GoogleDriveResponseDto> GetDriveDataAsync(string driveId);
}