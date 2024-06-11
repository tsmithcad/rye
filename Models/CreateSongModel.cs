public class CreateSongModel
{
    public CreateSongModel()
    {
        Id = Guid.NewGuid();
    }

    public  Guid Id { get; }
    public string? SongName { get; set; }
    public string? Lyrics { get; set; }
    public string? Songwriters { get; set; }
    public string? Artist { get; set; }
    public string? Feature { get; set; }
    public string? Producer { get; set; }
    public string? Instrumental { get; set; }
    public string? SplitSheet { get; set; }
    public string? Tempo { get; set; }
    public string? Key { get; set; }
    public string? LoudnessLFU { get; set; }
    public string? SongFilePath { get; set; }
    public string? RecordingDirPath { get; set; }
    public string? DAW { get; set; }
    public string? ArtworkFilePath { get; set; }
    public string? PerformanceTrack { get; set; }
    public string? Acapella { get; set; }
    public string? MixWav { get; set; }
    public string? MasterWav { get; set; }
    public string? PublishedMp3 { get; set; }
    public string? BassCheck { get; set; }
    public string? Metadata { get; set; }
    public string? YouTube { get; set; }
    public string? Apple { get; set; }
    public string? Spotify { get; set; }
    public string? Tidal { get; set; }
    public string? Instagram { get; set; }
    public string? TikTok { get; set; }
    public string? Facebook { get; set; }
    public bool PaidPerformance { get; set; }
    public bool OpenMic { get; set; }
    public bool WalkThrough { get; set; }
}
