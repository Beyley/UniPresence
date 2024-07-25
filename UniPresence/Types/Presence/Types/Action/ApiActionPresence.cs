using Newtonsoft.Json;
using UniPresence.Types.Presence.Lobby;

namespace UniPresence.Types.Presence.Types.Action;

[JsonObject]
public class ApiActionPresence
{
    /// <summary>
    /// The action the user is performing, such as `Editing`
    /// </summary>
    public string Action { get; set; }
    
    /// <summary>
    /// The location the action is taking place at, such as `UniPresence.sln`
    /// </summary>
    public string? Location { get; set; }
    /// <summary>
    /// The target of the action, such as `ApiPresenceAction.cs`
    /// </summary>
    public string? Target { get; set; }
    
    /// <summary>
    /// A qualified URL to an image representing the action, such as the C# logo if you are editing a C# file
    /// </summary>
    public string? ImageUrl { get; set; }
    
    /// <summary>
    /// A URL pointing to the target of the action, or representing the action as a whole
    /// </summary>
    public string? TargetUrl { get; set; }
    
    /// <summary>
    /// Extra button actions 
    /// </summary>
    public List<ApiPresenceButton>? Buttons { get; set; }
    
    public ApiLobbyInfo LobbyInfo { get; set; }
}