public interface ILocalDataService
{
    Task<List<TeamMember>> GetTeamMembersAsync();
    Task<List<DataCategory>> GetDataCategoriesAsync();
    Task<List<NavMenuItem>> GetNavMenuItemsAsync();
    Task<List<ContentCategory>> GetContentCategoriesAsync();
}

