using BepInEx;
using HarmonyLib;
using Timberborn.WalkingSystem;

namespace TB_WanderDisable
{
    public class Patcher
    {
        public static void DoPatching()
        {
            var harmony = new Harmony("TB_WanderDisable.Procdox.com.github");
            harmony.PatchAll();
        }
    }

    [HarmonyPatch(typeof(RandomDestinationPicker), "RandomDestination")]
    class PatchRandomWalk
    {
        static bool Prefix(RandomDestinationPicker __instance, UnityEngine.Vector3 __result, UnityEngine.Vector3 start)
        {
            __result = __instance.RandomDestinationNextToPosition(start, 5f, 0.5f);
            return false;
        }
    }
    [BepInPlugin("TB_WanderDisable.Procdox.com.github", "TB Wander Disabler", "1.0.0.0")]
    public class WD_Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            Patcher.DoPatching();
        }
    }
}
