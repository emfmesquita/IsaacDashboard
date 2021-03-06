﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using IsaacDashboard.Utils;
using static IsaacDashboard.Utils.MemoryReader;

namespace IsaacDashboard.Isaac {
    public class ModdedHelper {
        public static readonly int LastUnmoddedItemId = Items.AfterbirthPlusItems.Last().Key;
        public static readonly int LastUnmoddedTrinketId = Trinkets.AllTrinkets.Last().Key;
        public static readonly int UnmoddedPillsCount = Pills.AllPills.Count;

        private const int ModdedItemsInitOffset = 56968;
        private const int ModdedTrinketsInitOffset = 56980;
        private const int ModdedPillsInitOffset = 57028;
        private const string ModsDirRelPath = "My Games\\Binding of Isaac Afterbirth+ Mods";

        private static bool _loaded;
        private static readonly List<ModdedItem> ModdedItems = new List<ModdedItem>();
        private static readonly List<ModdedItem> ModdedTrinkets = new List<ModdedItem>();
        private static readonly List<ModdedItem> ModdedPills = new List<ModdedItem>();

        private static readonly string BaseModsDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), ModsDirRelPath);

        public static void Update(Status status, IIsaacReader reader) {
            if (!status.Ready || IsaacVersion.AfterbirthPlus != MemoryReader.GetVersion()) {
                Clear();
                return;
            }

            var abpReader = reader as AfterbirthPlusIsaacReader;
            if (abpReader == null) {
                Clear();
                return;
            }

            var numberOfPlayers = GetNumberOfPlayers();
            if (numberOfPlayers == 0) {
                Clear();
                return;
            }

            if (_loaded) {
                return;
            }

            _loaded = true;
            ModdedItems.Clear();
            ModdedItems.AddRange(LoadModdedItems());
            ModdedTrinkets.Clear();
            ModdedTrinkets.AddRange(LoadModdedTrinkets());
            ModdedPills.Clear();
            ModdedPills.AddRange(LoadModdedPills());
        }

        public static ModdedItem GetModdedItem(int id) {
            var moddedIndex = id - LastUnmoddedItemId - 1;
            return moddedIndex >= ModdedItems.Count ? null : ModdedItems[moddedIndex];
        }

        public static ModdedItem GetModdedTrinket(int id) {
            var moddedIndex = id - LastUnmoddedTrinketId - 1;
            return moddedIndex >= ModdedTrinkets.Count ? null : ModdedTrinkets[moddedIndex];
        }

        public static ModdedItem GetModdedPill(int id) {
            var moddedIndex = id - UnmoddedPillsCount;
            return moddedIndex >= ModdedPills.Count ? null : ModdedPills[moddedIndex];
        }

        public static int ModdedTrinketsCount() {
            return ModdedTrinkets.Count;
        }

        private static IEnumerable<ModdedItem> LoadModdedItems() {
            return GetModded(ModdedItemsInitOffset, LastUnmoddedItemId);
        }

        private static IEnumerable<ModdedItem> LoadModdedTrinkets() {
            return GetModded(ModdedTrinketsInitOffset, LastUnmoddedTrinketId);
        }

        private static IEnumerable<ModdedItem> LoadModdedPills() {
            return GetModded(ModdedPillsInitOffset, UnmoddedPillsCount, true, false);
        }

        private static IEnumerable<ModdedItem> GetModded(int initOffset, int lastUnmoded, bool zeroBased = false, bool loadLocation = true) {
            var moddedItems = new List<ModdedItem>();
            var moddedItemsInit = GetGameManagerInfo(initOffset, 4);
            var moddedItemsEnd = GetGameManagerInfo(initOffset + 4, 4);
            var firstIndex = zeroBased ? 0 : 1;
            var moddedItemsSize = (moddedItemsEnd - moddedItemsInit) / 4 - firstIndex - lastUnmoded;
            if (moddedItemsSize <= 0) {
                return moddedItems;
            }
            for (var i = 0; i < moddedItemsSize; i++) {
                var moddedItem = LoadModdedItem(lastUnmoded + firstIndex + i, moddedItemsInit, loadLocation);
                if (moddedItem != null) moddedItems.Add(moddedItem);
            }
            return moddedItems;
        }

        private static ModdedItem LoadModdedItem(int id, int moddedItemsInit, bool loadLocation = true) {
            var moddedItemPointer = ReadInt(moddedItemsInit + id * 4, 4);
            if (moddedItemPointer == 0) {
                return null;
            }

            var item = new ModdedItem() {
                Id = id,
                I18N = ReadModdedString(moddedItemPointer + 8)
            };
            if (!loadLocation) return item;
            item.ImageRelativeLocation = ReadModdedString(moddedItemPointer + 56);
            item.ImageAbsoluteLocation = ToAbsoluteLocation(item.ImageRelativeLocation);
            return item;
        }

        private static string ReadModdedString(int baseAddress) {
            var stringInfo = Read(baseAddress, 20);
            var size = MemoryReaderUtils.ConvertLittleEndian(stringInfo, 16, 4);
            if (size < 16) {
                return MemoryReaderUtils.ConvertToString(stringInfo, 0, size);
            }

            var stringPointer = MemoryReaderUtils.ConvertLittleEndian(stringInfo, 0, 4);
            return ReadString(stringPointer, size);
        }

        private static string ToAbsoluteLocation(string relativeLocation) {
            var windowsRelativeLocation = relativeLocation.Replace("/", "\\");
            return Directory.GetDirectories(BaseModsDir).Select(modDir => {
                var modResources = Path.Combine(modDir, "resources");
                return Path.Combine(modResources, windowsRelativeLocation);
            }).FirstOrDefault(File.Exists);
        }

        private static void Clear() {
            _loaded = false;
            ModdedItems.Clear();
            ModdedTrinkets.Clear();
            ModdedPills.Clear();
        }
    }
}
