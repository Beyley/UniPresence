using System.Reflection;
using Bunkum.Core;
using Bunkum.Protocols.Http;
using NotEnoughLogs;
using NotEnoughLogs.Behaviour;

LoggerConfiguration loggerConfiguration = new()
{
    Behaviour = new QueueLoggingBehaviour(),
#if DEBUG
    MaxLevel = LogLevel.Trace,
#else
    MaxLevel = LogLevel.Info,
#endif
};

// Initialize a Bunkum server for HTTP
BunkumServer server = new BunkumHttpServer(loggerConfiguration);

server.Initialize = s =>
{
    s.DiscoverEndpointsFromAssembly(Assembly.GetAssembly(typeof(Program))!);
};

// Start the server in multi-threaded mode, and let Bunkum manage the rest.
server.Start();
await Task.Delay(-1);