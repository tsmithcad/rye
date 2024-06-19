using System.Text.Json;


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
        return JsonSerializer.Deserialize<List<TeamMember>>(response);
    }

    public async Task<List<DataCategory>> GetDataCategoriesAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/data_roadmap.json");
        return JsonSerializer.Deserialize<List<DataCategory>>(response);
    }

    public async Task<List<NavMenuItem>> GetNavMenuItemsAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/nav_menu_items.json");
        return JsonSerializer.Deserialize<List<NavMenuItem>>(response);
    }

    public async Task<List<ContentCategory>> GetContentCategoriesAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/digital_service_providers.json");
        return JsonSerializer.Deserialize<List<ContentCategory>>(response);
    }

    public async Task<List<ContentCategory>> GetPerformanceRightsOrganizationsAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/performance_rights_organizations.json");
        return JsonSerializer.Deserialize<List<ContentCategory>>(response);
    }

    public async Task<List<ContentCategory>> GetEventPlatformsAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/event_platforms.json");
        return JsonSerializer.Deserialize<List<ContentCategory>>(response);
    }

    public async Task<List<ContentCategory>> GetMetadataFieldsAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/metadata_fields.json");
        return JsonSerializer.Deserialize<List<ContentCategory>>(response);
    }

    public async Task<List<UpdateItem>> GetUpdatesAsync()
    {
        var response = await _httpClient.GetStreamAsync("data/updates.json");
        return await JsonSerializer.DeserializeAsync<List<UpdateItem>>(response);
    }

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        var response = await _httpClient.GetStreamAsync("data/products.json");
        return await JsonSerializer.DeserializeAsync<List<Product>>(response);
    }
}
