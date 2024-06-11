using Google.Apis.Drive.v3;
using System.Threading.Tasks;

namespace RhymeEngine.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GoogleDriveController : ControllerBase
    {
        private readonly IDriveService driveService;

        public GoogleDriveController(IDriveService driveService)
        {
            this.driveService = driveService;
        }

        [HttpPost("create-rhyme-engine-structure")]
        public async Task<IActionResult> CreateRhymeEngineStructure(string googleDriveUrl, string userId)
        {
            try
            {
                // Authenticate and initialize the Google Drive API client
                var driveService = await AuthenticateGoogleDriveAsync(userId);

                // Create the root directory for Rhyme Engine
                var rhymeEngineRootFolderId = await CreateFolderAsync(driveService, "🎵 Rhyme Engine Root Directory", "root");

                // Songwriting and Composition
                var songwritingFolderId = await CreateFolderAsync(driveService, "📝 Songwriting and Composition", rhymeEngineRootFolderId);
                await CreateFolderAsync(driveService, "🎼 Lyrics", songwritingFolderId);
                await CreateFolderAsync(driveService, "🔀 Song Structures", songwritingFolderId);
                await CreateFolderAsync(driveService, "✏️ Drafts", songwritingFolderId);
                await CreateFolderAsync(driveService, "✔️ Final Versions", songwritingFolderId);
                await CreateFolderAsync(driveService, "👥 Collaborations", songwritingFolderId);

                // Producers
                var producersFolderId = await CreateFolderAsync(driveService, "🎧 Producers", rhymeEngineRootFolderId);
                var beatLibrariesFolderId = await CreateFolderAsync(driveService, "🎹 Beat Libraries", producersFolderId);
                await CreateFolderAsync(driveService, "🛒 Purchased", beatLibrariesFolderId);
                await CreateFolderAsync(driveService, "📃 Leased", beatLibrariesFolderId);
                await CreateFolderAsync(driveService, "🌟 Originals", beatLibrariesFolderId);
                await CreateFolderAsync(driveService, "🎚️ Projects", producersFolderId);
                await CreateFolderAsync(driveService, "💼 Invoices & Contracts", producersFolderId);

                // 🎤 Artists / Songwriters
                var artistsSongwritersFolderId = await CreateFolderAsync(driveService, "🎤 Artists / Songwriters", rhymeEngineRootFolderId);

                var profilesFolderId = await CreateFolderAsync(driveService, "🖼️ Profiles", artistsSongwritersFolderId);
                var discographiesFolderId = await CreateFolderAsync(driveService, "💿 Discographies", artistsSongwritersFolderId);
                var vocalsFolderId = await CreateFolderAsync(driveService, "🗣️ Vocals", artistsSongwritersFolderId);
                await CreateFolderAsync(driveService, "🔊 Raw", vocalsFolderId);
                await CreateFolderAsync(driveService, "✂️ Edited", vocalsFolderId);
                await CreateFolderAsync(driveService, "📜 Contracts & Agreements", artistsSongwritersFolderId);

                var musicProductionFolderId = await CreateFolderAsync(driveService, "🎚️ Music Production", artistsSongwritersFolderId);
                await CreateFolderAsync(driveService, "📁 Projects", musicProductionFolderId);
                await CreateFolderAsync(driveService, "🎉 Final Tracks", musicProductionFolderId);
                await CreateFolderAsync(driveService, "🧪 Demos", musicProductionFolderId);
                await CreateFolderAsync(driveService, "🎵 Backing Tracks & Instrumentals", musicProductionFolderId);
                await CreateFolderAsync(driveService, "💻 MIDI Files", musicProductionFolderId);
                await CreateFolderAsync(driveService, "🔌 Plugins & Presets", musicProductionFolderId);

                var recordingMasteringFolderId = await CreateFolderAsync(driveService, "🎙️ Recording and Mastering", artistsSongwritersFolderId);
                await CreateFolderAsync(driveService, "📆 Sessions", recordingMasteringFolderId);
                await CreateFolderAsync(driveService, "💎 Master Tracks", recordingMasteringFolderId);
                await CreateFolderAsync(driveService, "📝 Studio Bookings & Invoices", recordingMasteringFolderId);

                var copyrightRegistrationFolderId = await CreateFolderAsync(driveService, "©️ Copyright Registration", artistsSongwritersFolderId);
                await CreateFolderAsync(driveService, "📬 Submitted", copyrightRegistrationFolderId);
                await CreateFolderAsync(driveService, "⏳ Pending", copyrightRegistrationFolderId);
                await CreateFolderAsync(driveService, "✅ Approved", copyrightRegistrationFolderId);
                await CreateFolderAsync(driveService, "🎖️ Certificates", copyrightRegistrationFolderId);

                var musicPublishingFolderId = await CreateFolderAsync(driveService, "📚 Music Publishing", artistsSongwritersFolderId);
                await CreateFolderAsync(driveService, "📖 Published Works", musicPublishingFolderId);
                await CreateFolderAsync(driveService, "💰 Royalty Statements", musicPublishingFolderId);
                await CreateFolderAsync(driveService, "📄 Contracts & Agreements", musicPublishingFolderId);

                var albumArtworkFolderId = await CreateFolderAsync(driveService, "🎨 Album Artwork and Packaging", artistsSongwritersFolderId);
                await CreateFolderAsync(driveService, "✏️ Drafts", albumArtworkFolderId);
                await CreateFolderAsync(driveService, "🏆 Final Versions", albumArtworkFolderId);
                await CreateFolderAsync(driveService, "💾 Source Files", albumArtworkFolderId);
                await CreateFolderAsync(driveService, "🖨️ Print Ready", albumArtworkFolderId);


                // Music Legal Process
                var legalFolderId = await CreateFolderAsync(driveService, "⚖️ Music Legal Process", rhymeEngineRootFolderId);
                await CreateFolderAsync(driveService, "📜 Legal Advisories", legalFolderId);
                await CreateFolderAsync(driveService, "📁 Case Files", legalFolderId);
                await CreateFolderAsync(driveService, "📃 Contracts", legalFolderId);
                await CreateFolderAsync(driveService, "🥊 Disputes & Resolutions", legalFolderId);

                // Social Media Content
                var socialMediaFolderId = await CreateFolderAsync(driveService, "📱 Social Media Content", rhymeEngineRootFolderId);
                await CreateFolderAsync(driveService, "🖼️ Posts & Images", socialMediaFolderId);
                await CreateFolderAsync(driveService, "📊 Campaigns", socialMediaFolderId);
                await CreateFolderAsync(driveService, "📈 Analytics & Insights", socialMediaFolderId);

                // 🎟️ Music Events
                var musicEventsFolderId = await CreateFolderAsync(driveService, "🎟️ Music Events", rhymeEngineRootFolderId);
                await CreateFolderAsync(driveService, "📅 Upcoming", musicEventsFolderId);
                await CreateFolderAsync(driveService, "🗓️ Past Events", musicEventsFolderId);
                await CreateFolderAsync(driveService, "🎫 Tickets & Bookings", musicEventsFolderId);
                await CreateFolderAsync(driveService, "📣 Promotions & Marketing", musicEventsFolderId);

                // 🎨 Brand Development
                var brandDevelopmentFolderId = await CreateFolderAsync(driveService, "🎨 Brand Development", rhymeEngineRootFolderId);
                await CreateFolderAsync(driveService, "🛍️ Logos & Branding", brandDevelopmentFolderId);
                await CreateFolderAsync(driveService, "🎽 Merchandise", brandDevelopmentFolderId);
                await CreateFolderAsync(driveService, "📘 Brand Guidelines", brandDevelopmentFolderId);
                await CreateFolderAsync(driveService, "™️ Trademarks", brandDevelopmentFolderId);

                // 📢 Marketing
                var marketingFolderId = await CreateFolderAsync(driveService, "📢 Marketing", rhymeEngineRootFolderId);
                await CreateFolderAsync(driveService, "🚀 Campaigns", marketingFolderId);
                await CreateFolderAsync(driveService, "🎨 Ad Copies & Creatives", marketingFolderId);
                await CreateFolderAsync(driveService, "📊 Marketing Reports", marketingFolderId);
                await CreateFolderAsync(driveService, "💼 Collaborations & Partnerships", marketingFolderId);


                return Ok("Rhyme Engine directory structure successfully created in Google Drive.");
            }
            catch (Exception ex)
            {
                // Log and handle the error
                return StatusCode(500, $"An error occurred while creating the Rhyme Engine directory structure: {ex.Message}");
            }
        }



        private async Task<string> CreateFolderAsync(DriveService driveService, string folderName, string parentFolderId)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = folderName,
                MimeType = "application/vnd.google-apps.folder",
                Parents = new List<string> { parentFolderId }
            };

            var request = driveService.Files.Create(fileMetadata);
            var folder = await request.ExecuteAsync();

            return folder.Id;
        }


        public static void CreateMusicFolderStructure(string rootPath)
{
    var directories = new List<string>
    {
        "Songwriting and Composition\\Lyrics",
        "Songwriting and Composition\\Song Structures",
        "Songwriting and Composition\\Drafts",
        "Songwriting and Composition\\Final Versions",
        "Songwriting and Composition\\Collaborations",
        "Producers\\Beat Libraries\\Purchased",
        "Producers\\Beat Libraries\\Leased",
        "Producers\\Beat Libraries\\Originals",
        "Producers\\Projects",
        "Producers\\Invoices & Contracts",
        "Artists\\Profiles",
        "Artists\\Discographies",
        "Artists\\Vocals\\Raw",
        "Artists\\Vocals\\Edited",
        "Artists\\Contracts & Agreements",
        "Music Production\\Projects",
        "Music Production\\Final Tracks",
        "Music Production\\Demos",
        "Music Production\\Backing Tracks & Instrumentals",
        "Music Production\\MIDI Files",
        "Music Production\\Plugins & Presets",
        "Recording and Mastering\\Sessions",
        "Recording and Mastering\\Master Tracks",
        "Recording and Mastering\\Studio Bookings & Invoices",
        "Copyright Registration\\Submitted",
        "Copyright Registration\\Pending",
        "Copyright Registration\\Approved",
        "Copyright Registration\\Certificates",
        "Music Publishing\\Published Works",
        "Music Publishing\\Royalty Statements",
        "Music Publishing\\Contracts & Agreements",
        "Album Artwork and Packaging\\Drafts",
        "Album Artwork and Packaging\\Final Versions",
        "Album Artwork and Packaging\\Source Files",
        "Album Artwork and Packaging\\Print Ready",
        "Music Legal Process\\Legal Advisories",
        "Music Legal Process\\Case Files",
        "Music Legal Process\\Contracts",
        "Music Legal Process\\Disputes & Resolutions",
        "Performance Rights Organizations\\Registrations",
        "Performance Rights Organizations\\Events & Performances",
        "Performance Rights Organizations\\Royalty Collections",
        "Audio Distribution and Licensing\\Distributed Tracks",
        "Audio Distribution and Licensing\\Licensing Agreements",
        "Audio Distribution and Licensing\\Platforms & Services",
        "Online Video Distribution\\Video Files",
        "Online Video Distribution\\Thumbnails & Artworks",
        "Online Video Distribution\\Monetization Reports",
        "Social Media Content\\Posts & Images",
        "Social Media Content\\Campaigns",
        "Social Media Content\\Analytics & Insights",
        "Music Events\\Upcoming",
        "Music Events\\Past Events",
        "Music Events\\Tickets & Bookings",
        "Promotions & Marketing\\Brand Development",
        "Promotions & Marketing\\Logos & Branding",
        "Promotions & Marketing\\Merchandise",
        "Promotions & Marketing\\Brand Guidelines",
        "Promotions & Marketing\\Trademarks",
        "Promotions & Marketing\\Marketing",
        "Promotions & Marketing\\Campaigns",
        "Promotions & Marketing\\Ad Copies & Creatives",
        "Promotions & Marketing\\Marketing Reports",
        "Promotions & Marketing\\Collaborations & Partnerships"
    };

    foreach (var directory in directories)
    {
        Directory.CreateDirectory(Path.Combine(rootPath, directory));
    }
}

    }
}
