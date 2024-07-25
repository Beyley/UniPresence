using Bunkum.Core;
using Bunkum.Core.Endpoints;
using Bunkum.Listener.Protocol;
using Bunkum.Protocols.Http;
using UniPresence.Types.Consumer;
using UniPresence.Types.Presence;
using UniPresence.Types.Presence.Lobby;
using UniPresence.Types.Presence.Types.Action;
using UniPresence.Types.Presence.Types.Music;

namespace UniPresence.Endpoints.Consumer;

public class ConsumerEndpoints : EndpointGroup
{
    [HttpEndpoint("/presence/public/{user}", ContentType.Json)]
    public ApiPresenceCollection GetUsersPublicPresence(RequestContext context, string user)
    {
        return new ApiPresenceCollection
        {
            Presences =
            [
                new ApiApplicationPresence
                {
                    ApplicationInfo = new ApiApplicationInfo
                    {
                        Name = "VTOL VR",
                        Icon = "https://shitfuck.com/vtol.png",
                    },
                    MusicPresences =
                    [
                        new ApiMusicPresence
                        {
                            Artists = ["Christell"],
                            Title = "Dubidubidu",
                            Album = null,
                            CoverUrl = null,
                            Details = "on the plane's music player",
                            Progress = 123,
                            Length = 10000,
                            Url = null,
                            Buttons = null, 
                            LobbyInfo = new ApiLobbyInfo
                            {
                                Users = [new ApiLobbyUser {Name = "vtol doesnt actually sync music between players :("}],
                                StartTime = null,
                                EndTime = null,
                                Name = null,
                                ImageUrl = null,
                                LobbyUrl = null
                            },
                        }
                    ],
                    ActionPresences =
                    [
                        new ApiActionPresence
                        {
                            Action = "Flying an EF-24",
                            Location = "Hawking on Epstein island",
                            Target = null,
                            ImageUrl =
                                "https://steamuserimages-a.akamaihd.net/ugc/2286204343739458930/449ABCC2D3B9F744B5D08213C63B1402DC56AF92/?imw=268&imh=268&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=true",
                            TargetUrl = null,
                            Buttons =
                            [
                                new ApiPresenceButton
                                {
                                    Text = "Download map",
                                    Target = "https://steamcommunity.com/sharedfiles/filedetails/?id=3133479742",
                                },
                                new ApiPresenceButton()
                                {
                                    Text = "Join Lobby",
                                    Target = "vtol://joinlinkidk",
                                }
                            ],
                            LobbyInfo = new ApiLobbyInfo
                            {
                                Users =
                                [
                                    new ApiLobbyUser
                                    {
                                        Name = "Lyris",
                                        AvatarUrl = "https://crap.png",
                                        ProfileUrl = null,
                                    },
                                    new ApiLobbyUser
                                    {
                                        Name = "gup",
                                        AvatarUrl = null,
                                        ProfileUrl = null,
                                    },
                                ],
                                StartTime = 149151,
                                EndTime = 2348973789,
                                Name = "the best ef-24 on the damn planet",
                                ImageUrl = null,
                                LobbyUrl = null
                            },
                        }
                    ],
                }
            ],
        };      
    }
}