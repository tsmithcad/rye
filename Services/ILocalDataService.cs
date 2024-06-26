public interface ILocalDataService
{
    Task<List<TeamMember>> GetTeamMembersAsync();
    Task<List<DataCategory>> GetDataCategoriesAsync();
    Task<List<NavMenuItem>> GetNavMenuItemsAsync();
    Task<List<ContentCategory>> GetContentCategoriesAsync();
    Task<List<ContentCategory>> GetPerformanceRightsOrganizationsAsync();
    Task<List<ContentCategory>> GetEventPlatformsAsync();
    Task<List<ContentCategory>> GetMetadataFieldsAsync();
    Task<List<UpdateItem>> GetUpdatesAsync();
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<List<PageData>> GetPageDataAsync();
}

