using Newtonsoft.Json;

namespace UniPresence.Types.Presence.Lobby;

[JsonObject]
public class ApiLobbyUser
{
    /// <summary>
    /// The name of the user
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// A qualified URL pointing to the avatar of the user
    /// </summary>
    public string? AvatarUrl { get; set; }
    /// <summary>
    /// A URL pointing to the user's profile
    /// </summary>
    public string? ProfileUrl { get; set; }
}