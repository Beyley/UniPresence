using Newtonsoft.Json;

namespace UniPresence.Types.Presence.Lobby;

[JsonObject]
public class ApiLobbyInfo
{
    /// <summary>
    /// The amount of users in this lobby
    /// </summary>
    public List<ApiLobbyUser> Users { get; set; }

    /// <summary>
    /// The time the lobby started
    /// </summary>
    public uint? StartTime { get; set; }
    /// <summary>
    /// The time the lobby will conclude
    /// </summary>
    public uint? EndTime { get; set; }

    /// <summary>
    /// The name for the lobby
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// A fully qualified URL pointing to an image representing the lobby, mayhaps the logo for their clan/team
    /// </summary>
    public string? ImageUrl { get; set; }
    
    /// <summary>
    /// A URL pointing to a page showing more information about the lobby
    /// </summary>
    public string? LobbyUrl { get; set; }
}