using PokeD.BattleEngine.Monster.Data;

namespace PokeD.BattleEngine.Monster
{
    public interface IMonsterStaticData
    {
        short ID { get; }
        string Name { get; }
        MonsterTypes Types { get; }

        MonsterStats BaseStats { get; }
        byte CatchRate { get; }

        MonsterExperienceType ExperienceType { get; }

        short RewardExperience { get; }
        MonsterStats RewardStats { get; }

        MonsterEggGroups EggGroups { get; }

        byte LevelEvolveRequirement { get; }
    }
}
