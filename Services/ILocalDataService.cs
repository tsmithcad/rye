public interface ILocalDataService
{
    Task<List<TeamMember>> GetTeamMembersAsync();
    Task<List<DataCategory>> GetDataCategoriesAsync();
}

