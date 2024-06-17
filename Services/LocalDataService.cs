using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

public class LocalDataService
{
    private readonly HttpClient _httpClient;

    public LocalDataService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<TeamMember>> GetTeamMembersAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/team_members.json");
        return JsonSerializer.Deserialize<List<TeamMember>>(response);
    }

    public async Task<List<DataCategory>> GetDataCategoriesAsync()
    {
        var response = await _httpClient.GetStringAsync("Data/data_categories.json");
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
}
