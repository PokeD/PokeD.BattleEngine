namespace PokeD.BattleEngine.Map
{
    public class Region
    {
        public string Name { get; }
    }

    public class Location
    {
        public string Name { get; }
        public Region Region { get; }
    }
}
