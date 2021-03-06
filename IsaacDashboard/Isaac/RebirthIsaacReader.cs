﻿using System.Collections.Generic;
using static IsaacDashboard.Utils.MemoryReader;

namespace IsaacDashboard.Isaac {
    public class RebirthIsaacReader : IIsaacReader {
        private const int HasItemOffset = 3436;
        private const int ItemBlacklistOffset = 29080;
        private const int CursesOffset = 8;
        private const int TouchedTreeRootOffset = 28128;

        protected List<int> TouchedItems = new List<int>();

        public bool HasItem(Item item) {
            var offset = HasItemOffset + 4 * item.Id;
            return GetPlayerInfo(offset) > 0;
        }

        public List<int> GetItemsTouchedList() {
            TouchedItems.Clear();
            var rootPointer = GetPlayerManagerInfo(TouchedTreeRootOffset, 4);
            if (rootPointer == 0) {
                return TouchedItems;
            }

            var root = ReadInt(rootPointer + 4, 4);
            ReadNode(root);
            return TouchedItems;
        }

        public bool IsItemBlacklisted(Item item) {
            return GetPlayerManagerInfo(ItemBlacklistOffset + item.Id, 1) > 0;
        }

        public int GetFloorCurses() {
            return GetPlayerManagerInfo(CursesOffset, 1); ;
        }

        public int GetTimeCounter() {
            // TODO
            return 5;
        }

        public bool IsGamePaused() {
            // TODO
            return false;
        }

        public List<Item> GetPillPool() {
            // TODO
            return new List<Item>();
        }

        public List<bool> GetPillKnowledge() {
            // TODO
            return new List<bool>();
        }

        public int IndexOfLastPillTaken() {
            // TODO
            return 0;
        }

        public int GetSeed() {
            // TODO
            return 0;
        }

        public int GetPillCardId() {
            // TODO
            return 0;
        }

        public Consumable IsPillOrCard() {
            // TODO
            return Consumable.Card;
        }

        private void ReadNode(int nodePointer) {
            if (nodePointer == 0 || !IsFilled(nodePointer)) {
                return;
            }

            ReadNode(GetLeftNodePointer(nodePointer));
            TouchedItems.Add(GetTreeValue(nodePointer));
            ReadNode(GetRightNodePointer(nodePointer));
        }

        private static bool IsFilled(int nodePointer) {
            return ReadInt(nodePointer + 37, 1) == 0;
        }

        private static int GetLeftNodePointer(int nodePointer) {
            return ReadInt(nodePointer, 4);
        }

        private static int GetRightNodePointer(int nodePointer) {
            return ReadInt(nodePointer + 8, 4);
        }

        private static int GetTreeValue(int nodePointer) {
            return ReadInt(nodePointer + 16, 4);
        }
    }
}
