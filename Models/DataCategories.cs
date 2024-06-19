using System.ComponentModel.DataAnnotations;

public class DataCategory
{
    [Required]
    [StringLength(100, ErrorMessage = "Category cannot be longer than 100 characters.")]
    public string Category { get; set; }

    [Required]
    public List<DataSource> DataSources { get; set; }
}

public class DataSource
{
    [Required]
    [StringLength(100, ErrorMessage = "SourceName cannot be longer than 100 characters.")]
    public string SourceName { get; set; }

    [Required]
    public List<string> FileExtensions { get; set; }
}

public class ContentCategory
{
    [Required]
    [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
    public string Title { get; set; }

    [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
    public string Description { get; set; }

    [Required]
    public bool Enabled { get; set; }

    [Required]
    public List<Platform> Platforms { get; set; }
}

public class Platform
{
    [Required]
    [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
    public string Name { get; set; }

    [Url(ErrorMessage = "Please enter a valid URL.")]
    [StringLength(200, ErrorMessage = "Url cannot be longer than 200 characters.")]
    public string Url { get; set; }

    [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
    public string Description { get; set; }
}

public class UpdateItem
{
    [Required]
    [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
    public string Title { get; set; }

    [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
    public string Description { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public string Date { get; set; }
}
