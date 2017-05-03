using PokeD.BattleEngine.Monster.Data;

using System.Collections.Generic;

namespace PokeD.BattleEngine.Monster
{
    public interface IMonsterStaticData
    {
        Dictionary<byte, Move> MovesLearnableByLevel { get; }

        int Height { get; }
        int Weight { get; }

        short ID { get; }
        string Name { get; }

        MonsterTypes Types { get; }
        EggGroups EggGroups { get; }

        Stats BaseStats { get; }

        byte CatchRate { get; }
        //byte EscapeRate { get; }

        int HatchCycles { get; }
        
        byte Color { get; }
        byte Shape { get; }
        byte Footprint { get; }

        ExperienceType ExperienceType { get; }

        short RewardExperience { get; }
        Stats RewardStats { get; }

        EvolutionCondition EvolutionCondition { get; }
    }
}
