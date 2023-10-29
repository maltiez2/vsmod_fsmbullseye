using Vintagestory.API.Common;

namespace MaltiezFSM.BullseyeCompatibility
{
    public class MaltiezFsmBullseyeExtensionSystem : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);

            api.RegisterCollectibleBehaviorClass("SmoothAnimationAttachable", typeof(SmoothAnimationAttachableBehavior));

            var factory = api.ModLoader.GetModSystem<FiniteStateMachineSystem>().GetSystemFactory();

            factory.RegisterType<SmoothAnimation>("SmoothAnimation");
            factory.RegisterType<BullseyeAiming>("BullseyeAiming");
        }
    }
}
