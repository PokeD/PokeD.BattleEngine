using System;

namespace PokeD.BattleEngine.Monster.Data
{
    public class MonsterEggGroup
    {
        public static MonsterEggGroup None => new MonsterEggGroup(0, "NONE");

        public int ID { get; }
        public string Name { get; }

        public MonsterEggGroup(int id, string name) { ID = id; Name = name; }

        public override string ToString() => $"{Name}, ID: {ID}";
    }

    public class MonsterEggGroups
    {
        public static MonsterEggGroups None => new MonsterEggGroups();

        public MonsterEggGroup Type_0 { get; } = MonsterEggGroup.None;
        public MonsterEggGroup Type_1 { get; } = MonsterEggGroup.None;

        public MonsterEggGroups(params MonsterEggGroup[] eggGroups)
        {
            if (eggGroups.Length > 0)
                Type_0 = eggGroups[0];

            if (eggGroups.Length > 1)
                Type_1 = eggGroups[1];

            if (eggGroups.Length > 2)
                throw new ArgumentOutOfRangeException();
        }

        public override string ToString() => $"Type1: {Type_0}; Type2: {Type_1}";


        public bool Contains(MonsterEggGroup eggGroup) => Type_0 == eggGroup || Type_1 == eggGroup;
        public bool Contains(short eggGroupID) => Type_0.ID == eggGroupID || Type_1.ID == eggGroupID;
    }
}