using System.Collections.Generic;
using PokeD.BattleEngine.Attack;
using PokeD.BattleEngine.Monster.Calculation;
using PokeD.BattleEngine.Monster.Data;

namespace PokeD.BattleEngine.Monster
{
    public abstract class BaseMonsterInstance
    {
        public IMonsterStaticData StaticData { get; }

        //public ushort SecretID { get; protected set; }
        public CatchInfo CatchInfo { get; protected set; }

        //uint PersonalityValue { get; }

        public Gender Gender { get; protected set; }

        public Ability Ability { get; protected set; }
        public byte Nature { get; protected set; }

        public long Experience { get; protected set; }
        public virtual byte Level => ExperienceCalculator.LevelForExperienceValue(StaticData.ExperienceType, Experience);

        public Stats IV { get; protected set; }
        public Stats EV { get; protected set; }

        public short CurrentHP { get; protected set; }
        public short StatusEffect { get; protected set; }

        public byte Affection { get; protected set; }
        public byte Friendship { get; protected set; }

        public bool IsShiny { get; protected set; }

        public IList<IAttackInstance> Moves { get; protected set; }

        public short HeldItem { get; protected set; }

        public BaseMonsterInstance(IMonsterStaticData staticData) { StaticData = staticData; }
    }
    /*
    public interface IMonsterInstance
    {
        IMonsterStaticData StaticData { get; }

        ushort SecretID { get; }
        CatchInfo CatchInfo { get; }

        //uint PersonalityValue { get; }

        Gender Gender { get; }

        Ability Ability { get; }
        byte Nature { get; }

        int Experience { get; }
        byte Level { get; }

        Stats IV { get; }
        Stats EV { get; }

        short CurrentHP { get; }
        short StatusEffect { get; }

        byte Affection { get; }
        byte Friendship { get; }

        Moves Moves { get; }

        short HeldItem { get; }
    }
    */
}
