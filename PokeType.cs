namespace PokeD.BattleEngine
{
    public class PokeType
    {
        public static PokeType None => new PokeType(0, "EMPTY");

        public int ID { get; }
        public string Name { get; }

        public PokeType(int id, string name) { ID = id; Name = name; }

        public override string ToString() => $"{Name}, ID: {ID}";
    }
}