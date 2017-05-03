using PokeD.BattleEngine.Monster.Data;

namespace PokeD.BattleEngine.Monster
{
    public interface IMonsterInstance
    {
        IMonsterStaticData StaticData { get; }

        short Species { get; }
        ushort SecretID { get; }
        CatchInfo CatchInfo { get; }

        uint PersonalityValue { get; }

        Gender Gender { get; }

        Ability Ability { get; }
        byte Nature { get; }

        int Experience { get; }
        byte Level { get; }

        Stats IV { get; }
        Stats EV { get; }
        Stats HiddenEV { get; }

        short CurrentHP { get; }
        short StatusEffect { get; }

        byte Affection { get; }
        byte Friendship { get; }

        Moves Moves { get; }

        short HeldItem { get; }
    }
}
