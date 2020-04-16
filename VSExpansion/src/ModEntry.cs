using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace VSExpansion.src
{
    public class ModEntry : ModSystem
    {
        public const string MOD_ID = "vsex";

        public ICoreClientAPI        ClientAPI     { get; private set; }
        public IClientNetworkChannel ClientChannel { get; private set; }
        public ICoreServerAPI        ServerAPI     { get; private set; }
        public IServerNetworkChannel ServerChannel { get; private set; }
        public override bool ShouldLoad(EnumAppSide forSide) => true;

        public override void Start(ICoreAPI api)
        {
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            ClientAPI = api;
            ClientChannel = api.Network.RegisterChannel(MOD_ID);
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            ServerAPI = api;
            ServerChannel = api.Network.RegisterChannel(MOD_ID);
        }
    }
}