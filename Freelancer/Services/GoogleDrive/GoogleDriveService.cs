
using Freelancer.Models.Dto;
using Freelancer.Options;

using Microsoft.Extensions.Options;

namespace Freelancer.Services.GoogleDrive;

public class GoogleDriveService : IGoogleDriveService
{
    private readonly HttpClient _httpClient;
    private readonly GoogleDriveOptions _options;

    public GoogleDriveService(HttpClient httpClient, IOptions<GoogleDriveOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;
    }
    public async Task<GoogleDriveResponseDto> GetDriveDataAsync(string driveId)
    {
        var url = $"{_options.BaseUrl}?q=\'{driveId}\'+in+parents&key={_options.ApiKey}&supportsAllDrives=true&includeItemsFromAllDrives=true";

        var response = await _httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            return await response?.Content?.ReadFromJsonAsync<GoogleDriveResponseDto>();
        }
        throw new NotImplementedException();
    }
}