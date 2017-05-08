using System;

namespace PokeD.BattleEngine.Monster.Data
{
    public class MonsterType
    {
        public static MonsterType None => new MonsterType(0, "NONE");

        public int ID { get; }
        public string Name { get; }

        public MonsterType(int id, string name) { ID = id; Name = name; }

        public override string ToString() => $"{Name}";
    }

    public class MonsterTypes
    {
        public static MonsterTypes None => new MonsterTypes();

        public MonsterType Type_0 { get; } = MonsterType.None;
        public MonsterType Type_1 { get; } = MonsterType.None;

        public MonsterTypes(params MonsterType[] types)
        {
            if (types.Length > 0)
                Type_0 = types[0];

            if (types.Length > 1)
                Type_1 = types[1];

            if (types.Length > 2)
                throw new Exception();
        }

        public override string ToString() => Type_1.Equals(MonsterType.None) ? $"{Type_0}, {Type_1}" : $"{Type_0}";


        public bool Contains(MonsterType type) => Type_0 == type || Type_1 == type;
        public bool Contains(short type) => Type_0.ID == type || Type_1.ID == type;
    }
}