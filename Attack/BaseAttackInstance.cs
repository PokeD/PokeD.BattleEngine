using System;

using PokeD.BattleEngine.Monster;

namespace PokeD.BattleEngine.Attack
{
    public abstract class BaseAttackInstance
    {
        public IAttackStaticData StaticData { get; }

        public byte PPCurrent { get; }
        public byte PPUps { get; }
        public virtual byte PPMax => (byte) (StaticData.PP + (byte) Math.Round((double) StaticData.PP * PPUps * 0.20D));


        public BaseAttackInstance(IAttackStaticData staticData) { StaticData = staticData; PPCurrent = StaticData.PP; }
        public BaseAttackInstance(IAttackStaticData staticData, byte pp, byte ppUps) : this(staticData) { PPCurrent = pp; PPUps = ppUps; }

        public override string ToString() => $"{PPCurrent,2}/{PPMax,2} {StaticData}";
    }
}