using IsaacDashboard.Isaac;

namespace IsaacDashboard.Utils {
    public class ResourcesUtil {
        public static string UnmoddedItemResource(int id) {
            return $"IsaacDashboard.Images.Items.c{id}.png";
        }
        public static string ItemResource(Item item) {
            var moddedItem = item as ModdedItem;
            return moddedItem == null ? UnmoddedItemResource(item.Id) : moddedItem.ImageAbsoluteLocation;
        }

        public static string PillResource(int pillNumber) {
            return $"IsaacDashboard.Images.Pills.pill{pillNumber}.png";
        }

        public static string UnmoddedTrinketResource(int id) {
            return $"IsaacDashboard.Images.Trinkets.t{id}.png";
        }
        public static string TrinketResource(Item item) {
            var moddedItem = item as ModdedItem;
            return moddedItem == null ? UnmoddedTrinketResource(item.Id) : moddedItem.ImageAbsoluteLocation;
        }
    }
}
