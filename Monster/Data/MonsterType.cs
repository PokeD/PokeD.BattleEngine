using System;

namespace PokeD.BattleEngine.Monster.Data
{
    public class MonsterTypes
    {
        public static MonsterTypes None => new MonsterTypes();

        public PokeType Type_0 { get; } = PokeType.None;
        public PokeType Type_1 { get; } = PokeType.None;

        public MonsterTypes(params PokeType[] types)
        {
            if (types.Length > 0)
                Type_0 = types[0];

            if (types.Length > 1)
                Type_1 = types[1];

            if (types.Length > 2)
                throw new Exception();
        }

        public override string ToString() => $"Type1: {Type_0}; Type2: {Type_1}";


        public bool Contains(PokeType type) => Type_0 == type || Type_1 == type;
        public bool Contains(short type) => Type_0.ID == type || Type_1.ID == type;
    }
}