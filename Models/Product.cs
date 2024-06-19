using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    [Required]
    [StringLength(36, ErrorMessage = "ProductID cannot be longer than 36 characters.")]
    public string ProductID { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "ProductName cannot be longer than 100 characters.")]
    public string ProductName { get; set; }

    [Required]
    [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
    public string Description { get; set; }

    [Required]
    [Range(0, 10000, ErrorMessage = "Price must be between 0 and 10,000.")]
    public decimal Price { get; set; }

    [Url(ErrorMessage = "Please enter a valid URL.")]
    [StringLength(200, ErrorMessage = "ImageUrl cannot be longer than 200 characters.")]
    public string ImageUrl { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "PurchaseType cannot be longer than 50 characters.")]
    public string PurchaseType { get; set; }

    [StringLength(1000, ErrorMessage = "MarketingMessage cannot be longer than 1000 characters.")]
    public string MarketingMessage { get; set; }

    [StringLength(50, ErrorMessage = "SubscriptionDuration cannot be longer than 50 characters.")]
    public string SubscriptionDuration { get; set; }
}
