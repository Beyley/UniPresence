using Newtonsoft.Json;

namespace UniPresence.Types.Presence;

[JsonObject]
public class ApiPresenceButton
{
    /// <summary>
    /// The text on the button
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// The target URL the user will be brought to when the button is clicked
    /// </summary>
    public string Target { get; set; }
}