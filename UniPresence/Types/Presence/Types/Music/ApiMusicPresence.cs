using Newtonsoft.Json;
using UniPresence.Types.Presence.Lobby;

namespace UniPresence.Types.Presence.Types.Music;

[JsonObject]
public class ApiMusicPresence
{
    /// <summary>
    /// The artists that composed the music
    /// </summary>
    public List<string>? Artists { get; set; }
    /// <summary>
    /// The title of the track
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// The album the track was released on
    /// </summary>
    public string? Album { get; set; }
    /// <summary>
    /// A fully qualified URL to the image cover for this track/album
    /// </summary>
    public string? CoverUrl { get; set; }
    
    /// <summary>
    /// Some misc details string for the listening, such as "Jamming out" or "on the plane's music player"
    /// </summary>
    public string? Details { get; set; }
    
    /// <summary>
    /// The timestamp the user is at, in milliseconds
    /// </summary>
    public uint? Progress { get; set; }
    /// <summary>
    /// The length of the song, in milliseconds
    /// </summary>
    public uint? Length { get; set; }

    /// <summary>
    /// An optional URL containing a link to the music
    /// </summary>
    public string? Url { get; set; }
    
    /// <summary>
    /// Extra button actions 
    /// </summary>
    public List<ApiPresenceButton>? Buttons { get; set; }

    public ApiLobbyInfo LobbyInfo { get; set; }
}