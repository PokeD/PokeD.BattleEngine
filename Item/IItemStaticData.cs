﻿using System.Collections.Generic;

using PokeD.BattleEngine.Item.Data;

namespace PokeD.BattleEngine.Item
{
    public interface IItemStaticData
    {
        int ID { get; }
        string Name { get; }

        IList<IItemAttribute> Attributes { get; }
    }
}