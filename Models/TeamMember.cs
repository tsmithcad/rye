public class TeamMember
{
    public string? SectionName { get; set; }
    public string? Role { get; set; }
    public List<string>? Tags { get; set; } = new List<string>();
    public List<string>? Responsibilities { get; set; } = new List<string>();
}
