namespace PokeD.BattleEngine.Monster.Data
{
    public class MonsterHeldItem
    {
        public static MonsterHeldItem None => new MonsterHeldItem(0, "NONE", 0);

        public int ID { get; }
        public string Name { get; }
        public int Rarity { get; }
        public IScript Script { get; }

        public MonsterHeldItem(int id, string name, int rarity) { ID = id; Name = name; Rarity = rarity; }

        public override string ToString() => $"{Name}, ID: {ID}, Rarity: {Rarity}";
    }
}