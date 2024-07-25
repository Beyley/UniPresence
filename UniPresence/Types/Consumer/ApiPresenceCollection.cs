using Newtonsoft.Json;
using UniPresence.Types.Presence;

namespace UniPresence.Types.Consumer;

[JsonObject]
public class ApiPresenceCollection
{
    public List<ApiApplicationPresence> Presences { get; set; } = [];
}