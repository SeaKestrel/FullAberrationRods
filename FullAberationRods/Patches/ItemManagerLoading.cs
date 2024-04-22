using HarmonyLib;
using Winch.Core;

namespace FullAberrationRods.Patch
{
    [HarmonyPatch(typeof(ItemManager), nameof(ItemManager.OnItemDataAddressablesLoaded))]
    internal class ItemManagerLoading
    {
        public static void Postfix(ItemManager __instance)
        {
            SpatialItemData VisceraCraneItem = __instance.GetItemDataById<SpatialItemData>("rod8"); // Get the wanted rod
                        SpatialItemData itemData = __instance.allItems.Find((ItemData od) => od.id == "rod17") as SpatialItemData; // Get a rod with the wanted shape
            __instance.allItems.Remove(VisceraCraneItem); // Remove the old rod
            VisceraCraneItem.dimensions = itemData.dimensions; // Setting the shape
            __instance.allItems.Add(VisceraCraneItem); // Adding the modified item

            WinchCore.Log.Info("Viscera Crane rod shape edited.");
        }
    }
}
