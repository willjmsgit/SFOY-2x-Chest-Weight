using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using Model;
using Model.Entities;

[BepInPlugin("wmj.sfoy.chestweight", "ChestWeight", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    public static ConfigEntry<float> Multiplier;

    void Awake()
    {
        Multiplier = Config.Bind("General", "ChestMultiplier", 2f, "Weight limit multiplier for chests");
        new Harmony("wmj.sfoy.chestweight").PatchAll();
    }
}

[HarmonyPatch(typeof(ResourcesContainer), "CalcLimitValue")]
static class ChestLimitPatch
{
    static readonly AccessTools.FieldRef<ResourcesContainer, ContainerLimitType> LimitType =
        AccessTools.FieldRefAccess<ResourcesContainer, ContainerLimitType>("_limitType");

    static void Postfix(ResourcesContainer __instance, ref float __result)
    {
        if (LimitType(__instance) == ContainerLimitType.Weight && __instance.Owner is ContainerComponent)
            __result *= Plugin.Multiplier.Value;
    }
}