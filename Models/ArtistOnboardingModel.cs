using System.ComponentModel.DataAnnotations;

public class ArtistOnboardingModel
{
    // Artist Details
    [Required, StringLength(100)]
    public string? ArtistName { get; set; }

    [Required, Url]
    public string? ProfilePicture { get; set; }

    [StringLength(500)]
    public string? Bio { get; set; }

    [Url]
    public string? Twitter { get; set; }

    [Url]
    public string? Instagram { get; set; }

    [Url]
    public string? Facebook { get; set; }

    [Url]
    public string? YouTube { get; set; }

    [Url]
    public string? TikTok { get; set; }

    [Url]
    public string? Website { get; set; }

    // Song Metadata
    [Required, StringLength(100)]
    public string? SongTitle { get; set; }

    [StringLength(100)]
    public string? ProducerName { get; set; }

    [StringLength(100)]
    public string? AlbumName { get; set; }

    [Required]
    public DateTime ReleaseDate { get; set; }

    [StringLength(50)]
    public string? Genre { get; set; }

    public TimeSpan SongDuration { get; set; }

    [Required, Url]
    public string? CoverArt { get; set; }

    // Lyrics
    public string? Lyrics { get; set; }

    // Audio Files
    [Required, Url]
    public string? FeaturedSong { get; set; }

    [Url]
    public string? Acapella { get; set; }

    [Url]
    public string? Instrumental { get; set; }

    [Url]
    public string? CleanVersion { get; set; }

    [Url]
    public string? ExplicitVersion { get; set; }

    [Url]
    public string? PerformanceVersion { get; set; }

    // Music Videos
    [Url]
    public string? MusicVideoURL { get; set; }

    public List<string> AdditionalVideos { get; set; } = new List<string>();

    // Related Content
    public List<string> RelatedContentLinks { get; set; } = new List<string>();

    // Production and Songwriting Credits
    [StringLength(100)]
    public string? SongwriterName { get; set; }

    [StringLength(500)]
    public string? RecordingDetails { get; set; }

    // Discography
    public List<DiscographyItem> Discography { get; set; } = new List<DiscographyItem>();

    // Upcoming Events
    public List<EventItem> UpcomingEvents { get; set; } = new List<EventItem>();

    // Fan Interaction
    public List<string> SocialMediaPosts { get; set; } = new List<string>();

    // Merchandise Store
    public List<MerchandiseItem> Merchandise { get; set; } = new List<MerchandiseItem>();

    // Press and Media
    public List<PressArticle> PressArticles { get; set; } = new List<PressArticle>();

    // Collaborations
    public List<Collaboration> Collaborations { get; set; } = new List<Collaboration>();

    // Artist Booking Information
    [Required, EmailAddress]
    public string? BookingEmail { get; set; }

    [Phone]
    public string? BookingPhone { get; set; }

    [Url]
    public string? BookingWebsite { get; set; }

    [StringLength(500)]
    public string? AdditionalBookingInfo { get; set; }

    // Visualizer and Graphics
    [Url]
    public string? SongVisualizer { get; set; }

    public List<string> PromotionalGraphics { get; set; } = new List<string>();

    // Performance and Tour Information
    [StringLength(500)]
    public string? PerformanceTips { get; set; }

    public List<EventItem> TourSchedule { get; set; } = new List<EventItem>();

    public List<CrewMember> CrewMembers { get; set; } = new List<CrewMember>();

    // System and Tools Integration
    [StringLength(50)]
    public string? DAW { get; set; }

    public int Tempo { get; set; }

    [StringLength(10)]
    public string? Key { get; set; }

    public List<string> ExternalTools { get; set; } = new List<string>();

    // Analytics and Reporting
    [StringLength(50)]
    public string? GoogleAnalyticsKey { get; set; }

    [StringLength(50)]
    public string? SocialMediaAnalyticsKey { get; set; }

    public List<SalesReport> SalesReports { get; set; } = new List<SalesReport>();

    // Marketing and Promotion
    public List<AdCampaign> AdCampaigns { get; set; } = new List<AdCampaign>();

    public List<FeaturedArtistTier> FeaturedArtistTiers { get; set; } = new List<FeaturedArtistTier>();

    public List<PlaylistPlacement> PlaylistPlacements { get; set; } = new List<PlaylistPlacement>();

    // Additional Notes
    public string? ProjectNotes { get; set; }

    public string? SpecialInstructions { get; set; }
}

public class DiscographyItem
{
    [Required, StringLength(100)]
    public string? Title { get; set; }

    [Required]
    public DateTime ReleaseDate { get; set; }

    [Required, Url]
    public string? CoverArt { get; set; }
}

public class EventItem
{
    [Required, StringLength(100)]
    public string? Name { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required, StringLength(100)]
    public string? Location { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }
}

public class MerchandiseItem
{
    [Required, StringLength(100)]
    public string? Name { get; set; }

    [Required, Range(0.01, 10000.00)]
    public decimal Price { get; set; }

    [Required, Url]
    public string? Image { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }
}

public class PressArticle
{
    [Required, StringLength(200)]
    public string? Title { get; set; }

    [Required, StringLength(100)]
    public string? Publication { get; set; }

    [Required, Url]
    public string? URL { get; set; }
}

public class Collaboration
{
    [Required, StringLength(100)]
    public string? CollaboratorName { get; set; }

    [Required, StringLength(100)]
    public string? ProjectTitle { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }
}

public class CrewMember
{
    [Required, StringLength(100)]
    public string? Role { get; set; }

    [Required, StringLength(100)]
    public string? Name { get; set; }
}

public class SalesReport
{
    [Required, StringLength(100)]
    public string? ReportType { get; set; }

    [StringLength(500)]
    public string? Details { get; set; }
}

public class AdCampaign
{
    [Required, StringLength(100)]
    public string? CampaignName { get; set; }

    [StringLength(500)]
    public string? Details { get; set; }
}

public class FeaturedArtistTier
{
    [Required, StringLength(100)]
    public string? TierName { get; set; }

    [StringLength(500)]
    public string? Benefits { get; set; }
}

public class PlaylistPlacement
{
    [Required, StringLength(100)]
    public string? PlaylistName { get; set; }

    [StringLength(500)]
    public string? Details { get; set; }
}
