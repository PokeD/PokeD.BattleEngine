using PokeD.BattleEngine.Monster.Data;

namespace PokeD.BattleEngine.Monster
{
    public interface IMonsterInstanceData
    {
        IMonsterStaticData StaticData { get; }

        short Species { get; }
        ushort SecretID { get; }
        MonsterCatchInfo CatchInfo { get; }

        uint PersonalityValue { get; }

        MonsterGender Gender { get; }

        MonsterAbility Ability { get; }
        byte Nature { get; }

        int Experience { get; }
        byte Level { get; }

        MonsterStats IV { get; }
        MonsterStats EV { get; }
        MonsterStats HiddenEV { get; }

        short CurrentHP { get; }
        short StatusEffect { get; }

        byte Affection { get; }
        byte Friendship { get; }

        MonsterMoves Moves { get; }

        short HeldItem { get; }
    }
}
