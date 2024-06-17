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

public class ContentCategory
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Enabled { get; set; }
    public List<DigitalServiceProvider> DigitalServiceProviders { get; set; }
}

public class DigitalServiceProvider
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
}
