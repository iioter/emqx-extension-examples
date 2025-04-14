using Emqx.Exhook.V2;
using Grpc.Core;
using System.Reflection;

namespace EmqxHook.Services
{
    public class HookProviderService : HookProvider.HookProviderBase
    {
        private readonly ILogger<HookProviderService> _logger;

        public HookProviderService(ILogger<HookProviderService> logger)
        {
            _logger = logger;
        }

        public override Task<LoadedResponse> OnProviderLoaded(ProviderLoadedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new LoadedResponse()
            {
                Hooks =
                {
                    new HookSpec() { Name = "client.connect" },
                    new HookSpec() { Name = "client.connack" },
                    new HookSpec() { Name = "client.connected" },
                    new HookSpec() { Name = "client.disconnected" },
                    new HookSpec() { Name = "client.authenticate" },
                    new HookSpec() { Name = "client.authorize" },
                    new HookSpec() { Name = "client.subscribe" },
                    new HookSpec() { Name = "client.unsubscribe" },

                    new HookSpec() { Name = "session.created" },
                    new HookSpec() { Name = "session.subscribed" },
                    new HookSpec() { Name = "session.unsubscribed" },
                    new HookSpec() { Name = "session.resumed" },
                    new HookSpec() { Name = "session.discarded" },
                    new HookSpec() { Name = "session.terminated" },

                    new HookSpec() { Name = "message.publish" },
                    new HookSpec() { Name = "message.delivered" },
                    new HookSpec() { Name = "message.acked" },
                    new HookSpec() { Name = "message.dropped" }
                }
            };
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnProviderUnloaded(ProviderUnloadedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        #region client

        public override Task<EmptySuccess> OnClientConnect(ClientConnectRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnClientConnack(ClientConnackRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnClientConnected(ClientConnectedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnClientDisconnected(ClientDisconnectedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<ValuedResponse> OnClientAuthenticate(ClientAuthenticateRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new ValuedResponse();
            return Task.FromResult(response);
        }

        public override Task<ValuedResponse> OnClientAuthorize(ClientAuthorizeRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new ValuedResponse();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnClientSubscribe(ClientSubscribeRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnClientUnsubscribe(ClientUnsubscribeRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        #endregion client

        #region session

        public override Task<EmptySuccess> OnSessionCreated(SessionCreatedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnSessionSubscribed(SessionSubscribedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnSessionUnsubscribed(SessionUnsubscribedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnSessionResumed(SessionResumedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnSessionDiscarded(SessionDiscardedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnSessionTakenover(SessionTakenoverRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnSessionTerminated(SessionTerminatedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        #endregion session

        #region message

        public override Task<ValuedResponse> OnMessagePublish(MessagePublishRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new ValuedResponse();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnMessageDelivered(MessageDeliveredRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnMessageAcked(MessageAckedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        public override Task<EmptySuccess> OnMessageDropped(MessageDroppedRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name}:\t{request}");
            var response = new EmptySuccess();
            return Task.FromResult(response);
        }

        #endregion message
    }
}