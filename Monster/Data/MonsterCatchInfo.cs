namespace PokeD.BattleEngine.Monster.Data
{
    public class MonsterCatchInfo
    {
        public static MonsterCatchInfo None => new MonsterCatchInfo();

        public string Full => $"{Method} {Location}";
        public string Method { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        public string TrainerName { get; set; } = string.Empty;
        public ushort TrainerID { get; set; }

        public byte PokeballID { get; set; }

        public string Nickname { get; set; } = string.Empty;
    }
}