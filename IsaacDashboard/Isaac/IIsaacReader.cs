﻿using System.Collections.Generic;

namespace IsaacDashboard.Isaac {
    public interface IIsaacReader {
        bool HasItem(Item item);

        List<int> GetItemsTouchedList();

        bool IsItemBlacklisted(Item item);

        int GetFloorCurses();

        int GetTimeCounter();

        bool IsGamePaused();

        List<Item> GetPillPool();

        List<bool> GetPillKnowledge();

        int IndexOfLastPillTaken();

        int GetSeed();

        int GetPillCardId();

        Consumable IsPillOrCard();
    }
}
