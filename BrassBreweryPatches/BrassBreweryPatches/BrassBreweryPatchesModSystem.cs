using Vintagestory.API.Client;
using Vintagestory.API.Server;
using Vintagestory.API.Config;
using Vintagestory.API.Common;

namespace BrassBreweryPatches;

public class BrassBreweryPatchesModSystem : ModSystem
{
    // Called on server and client
    // Useful for registering block/entity classes on both sides
    public override void Start(ICoreAPI api)
    {
        Mod.Logger.Notification("Loading "+ Mod.Info.Name + " on " + api.Side);
        
    }

    public override void StartServerSide(ICoreServerAPI api)
    {
        
    }

    public override void StartClientSide(ICoreClientAPI api)
    {

    }
}