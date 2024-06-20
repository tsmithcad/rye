using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class LocalDataService
{
    private readonly HttpClient _httpClient;

    public LocalDataService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<TeamMember>> GetTeamMembersAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/team.json");
        return JsonSerializer.Deserialize<List<TeamMember>>(response) ?? new List<TeamMember>();
    }

    public async Task<List<DataCategory>> GetDataCategoriesAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/data_roadmap.json");
        return JsonSerializer.Deserialize<List<DataCategory>>(response) ?? new List<DataCategory>();
    }

    public async Task<List<NavMenuItem>> GetNavMenuItemsAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/navigation.json");
        return JsonSerializer.Deserialize<List<NavMenuItem>>(response) ?? new List<NavMenuItem>();
    }

    public async Task<List<ContentCategory>> GetContentCategoriesAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/digital_service_providers.json");
        return JsonSerializer.Deserialize<List<ContentCategory>>(response) ?? new List<ContentCategory>();
    }

    public async Task<List<ContentCategory>> GetPerformanceRightsOrganizationsAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/performance_rights_organizations.json");
        return JsonSerializer.Deserialize<List<ContentCategory>>(response) ?? new List<ContentCategory>();
    }

    public async Task<List<ContentCategory>> GetEventPlatformsAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/event_platforms.json");
        return JsonSerializer.Deserialize<List<ContentCategory>>(response) ?? new List<ContentCategory>();
    }

    public async Task<List<ContentCategory>> GetMetadataFieldsAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/metadata_fields.json");
        return JsonSerializer.Deserialize<List<ContentCategory>>(response) ?? new List<ContentCategory>();
    }

    public async Task<List<UpdateItem>> GetUpdatesAsync()
    {
        var response = await _httpClient.GetStreamAsync("data/updates.json");
        return await JsonSerializer.DeserializeAsync<List<UpdateItem>>(response) ?? new List<UpdateItem>();
    }

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        var response = await _httpClient.GetStreamAsync("data/products.json");
        return await JsonSerializer.DeserializeAsync<List<Product>>(response) ?? new List<Product>();
    }

    public async Task<List<PageData>> GetPageDataAsync()
    {
        string json = await _httpClient.GetStringAsync("/data/futurePages.json");
        return JsonSerializer.Deserialize<List<PageData>>(json) ?? new List<PageData>();
    }
}
