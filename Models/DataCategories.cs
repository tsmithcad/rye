public class DataCategory
{
    public string Category { get; set; }
    public List<DataSource> DataSources { get; set; }
}

public class DataSource
{
    public string SourceName { get; set; }
    public List<string> FileExtensions { get; set; }
}
