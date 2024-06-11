public class DataItem
{
    public int ID { get; set; }
    public string? Description { get; set; }
    public string? URL { get; set; }
    public bool ShowPrice { get; set; } = false;
    public decimal? Price { get; set; }
    public string? PageName { get; set; }
}
