using System;

using PokeD.BattleEngine.Monster;

namespace PokeD.BattleEngine.Attack
{
    public abstract class BaseAttackInstance
    {
        public IAttackStaticData StaticData { get; }

        public IMonsterStaticData User { get; }

        public byte PPCurrent { get; }
        public byte PPUps { get; }
        public virtual byte PPMax => (byte) (StaticData.PP + (byte) Math.Round((double) StaticData.PP * PPUps * 0.20D));


        public BaseAttackInstance(IAttackStaticData staticData, IMonsterStaticData user) { StaticData = staticData; User = user; PPCurrent = StaticData.PP; }
        public BaseAttackInstance(IAttackStaticData staticData, byte pp, byte ppUps, IMonsterStaticData user) : this(staticData, user) { PPCurrent = pp; PPUps = ppUps; }

        public override string ToString() => $"{PPCurrent,2}/{PPMax,2} {StaticData}";
    }
}